using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class CookedCake : MonoBehaviour
{
    public float timeRemaining = 5;
    public bool timerIsRunning = false;
    public TMPro.TextMeshPro timeText;

    public RecipeObject recipe;
    void Start()
    {
        recipe = GameObject.Find("RecipeData").GetComponent<RecipeObject>();
    }

    void Update()
    {
        if (timerIsRunning && recipe.ovenTurnedOn)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                //DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("cake over!");
                timeRemaining = 0;
                timerIsRunning = false;
                recipe.bakedCake.transform.GetChild(0).gameObject.GetComponent<MeshRenderer>().material.color = new Color(0.3f, 0.2f, 0);
                recipe.cakeBurned = true;
            }
        }
        else if (timerIsRunning && !recipe.ovenTurnedOn)
        {
            GameObject.Find("ovenPress").SetActive(false);
            enabled = false;
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
