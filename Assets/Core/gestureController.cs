using Oculus.Interaction;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class gestureController : MonoBehaviour
{

    public GameObject prefabCube;
    public GameObject prefabSphere;
    public Transform spawnTransform;

    public ActiveStateSelector gestureThumbsUpR;
    public ActiveStateSelector gestureThumbsUpL;
    public ActiveStateSelector gestureScissorsR;
    public ActiveStateSelector gestureScissorsL;

    private bool[,] gesturesActive = new bool[7,2];
    private int[,] gesturesCombis = new int[,] { 
        { 0, 0},
        { 1, 1},
        { 1, 0},
        { 0, 1},
    };

    public ActiveStateSelector[] gestureObjects; 
    public GameObject[] ingredients = new GameObject[6];

    // Start is called before the first frame update
    void Start()
    {
        gestureScissorsR.WhenSelected += () => SpawnIngredient(0, 0);
        gestureScissorsL.WhenSelected += () => SpawnIngredient(0, 1);

        gestureScissorsR.WhenUnselected += () => { gesturesActive[0, 0] = false; };
        gestureScissorsL.WhenUnselected += () => { gesturesActive[0, 1] = false; };

        gestureThumbsUpR.WhenSelected += () => SpawnIngredient(1, 0);
        gestureThumbsUpL.WhenSelected += () => SpawnIngredient(1, 1);

        gestureThumbsUpR.WhenUnselected += () => { gesturesActive[1, 0] = false; };
        gestureThumbsUpL.WhenUnselected += () => { gesturesActive[1, 1] = false; };

        //int counter = 0; //alle zwei
        //for (int key = 0; key < 2; key++)
        //{
        //    Debug.Log("hand nr:" + key % 2);
        //    Debug.Log("gestur obj:" + key);
        //    Debug.Log("gestur nr:" + counter);
        //    gestureObjects[key].WhenSelected += () => SpawnIngredient(key, key % 2);
        //    gestureObjects[key].WhenUnselected += () => { gesturesActive[key, key % 2] = false; };

        //    if (key % 2==1) counter++;
        //}

    }
    void SpawnPrefab(GameObject prefab)
    {
        
        Instantiate(prefab, spawnTransform.position, spawnTransform.rotation);
    }

    void SpawnIngredient(int gesture, int handNr)
    {
        gesturesActive[gesture, handNr] = true;


        for (int i = 0; i < 4; i++)
        { 
            if (gesturesActive[gesturesCombis[i, 0], 0] & gesturesActive[gesturesCombis[i, 1], 1])
            {
                gestureThumbsUpR.gameObject.transform.GetChild(0).gameObject.GetComponent<AudioTrigger>().PlayAudio();
                Instantiate(ingredients[i], spawnTransform.position, spawnTransform.rotation);
                //return;
            }
        }
    }
}
