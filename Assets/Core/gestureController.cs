using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestureController : MonoBehaviour
{

    public GameObject prefabCube;
    public GameObject prefabSphere;
    public Transform spawnTransform;

    public ActiveStateSelector gestureThumbsUp;
    public ActiveStateSelector gestureScissors;

    // Start is called before the first frame update
    void Start()
    {
        gestureThumbsUp.WhenSelected += () => SpawnPrefab(prefabCube);
        gestureScissors.WhenSelected += () => SpawnPrefab(prefabSphere);
    }
    void SpawnPrefab(GameObject prefab)
    {
        Instantiate(prefab, spawnTransform.position, spawnTransform.rotation);
    }
}
