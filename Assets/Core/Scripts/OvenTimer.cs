using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenTimer : MonoBehaviour
{
    public float timeRemaining = 10;
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
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;

                recipe.SetStep(6);
                recipe.CakeTransformation();
            }
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
