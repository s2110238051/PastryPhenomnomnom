using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class RecipeObject : MonoBehaviour
{

    //step 1 => 
    /* STEPS
     * step 1: drop ingredients into bowl, umrühren => step++; pie transform
     * step 2: drop ingredients again, umrühren => step++;
     * step 3: pie in the oven => step++
     * step 4: get pie out, smear creme on top => donzo
     */ 

    // calculate score

    // umrühren

    public int currentStep = 0;
    public TextMeshProUGUI stepTextObj;
    public string[] stepTexts;

    public void SetStep(int next)
    {
        currentStep = next;
        stepTextObj.text = stepTexts[currentStep];
    }



    // ingredient tag, [soll wert, ist wert]
    private Dictionary<string, int[]> doughIngridients = new Dictionary<string, int[]>() {
        { "flour", new int[] {3,0 } },
        { "eggs", new int[] {2,0 } },
        { "sugar", new int[] {4,0 } },
        { "milk", new int[] {2,0 } },
        { "water", new int[] {0,0 } },
        { "strawberries", new int[] {0,0 } }
    };

    private Dictionary<string, int[]> frostingIngridients = new Dictionary<string, int[]>() {
        { "flour", new int[] {0,0 } },
        { "eggs", new int[] {0,0 } },
        { "milk", new int[] {0,0 } },
        { "water", new int[] {1,0 } },
        { "sugar", new int[] {4,0 } },
        { "strawberries", new int[] {4,0 } }
    };

    public GameObject BigSpoon;
    public GameObject SmallSpoon;

    public GameObject dough;
    public GameObject doughUp4Grabs;

    public GameObject toppingMix;


    public GameObject formInOven;
    public GameObject bakedCake;
    public GameObject finishedCake;
    public ParticleSystem ParticleSystemFinish;

    public bool cakeBurned = false;


    public Dictionary<string, int[]> GetIngredients()
    {
        switch(currentStep)
        {
            case <=2: return doughIngridients;
            case >=3: return frostingIngridients;
            //default: return new Dictionary<string, int[]>();
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CakeTransformation()
    {
        if (currentStep == 3)
        {
            dough.SetActive(false);
            doughUp4Grabs.SetActive(true);
        } 
        else if( currentStep == 6)
        {
            formInOven.SetActive(false);
            bakedCake.SetActive(true);
        } else if(currentStep == 10)
        {
            finishedCake.transform.position = bakedCake.transform.position;
            bakedCake.SetActive(false);
            finishedCake.SetActive(true);
            ParticleSystemFinish.Play();
            CalcScore();

        }
    }


    public bool cakeInOven = false;
    public bool ovenTurnedOn = false;
    public OvenTimer ovenTimer;

    // step
    public void StartOvenTimer()
    {
        if(cakeInOven && ovenTurnedOn) { ovenTimer.timerIsRunning = true; SetStep(5);  }
    }

    public bool ValidatePatter(Dictionary<string, int[]> ingridis)
    {
        foreach (string key in ingridis.Keys)
        {
            if (ingridis[key][1] != ingridis[key][0])
                return false;
        }

        return true;
    }

    public GameObject fertigUI;
    public GameObject star1;
    public GameObject star2; 
    public GameObject star3;
    public TextMeshProUGUI scorText;

    public void CalcScore()
    {
        int score = 0;

        if (ValidatePatter(doughIngridients)) score++;
        if (ValidatePatter(frostingIngridients)) score++;
        if (!cakeBurned) score++;

        fertigUI.SetActive(true);

        switch (score)
        {
            case 1:
                star1.SetActive(true);
                scorText.text = "1/3";
                break;
            case 2:
                star2.SetActive(true);
                scorText.text = "3/3";
                break;
            case 3:
                star1.SetActive(true);
                scorText.text = "3/3";
                break;
            default:
                scorText.text = "0/3";
                break;
        }
    }

}


