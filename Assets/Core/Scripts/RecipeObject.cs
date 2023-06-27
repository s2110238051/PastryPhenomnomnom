using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
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
        { "sugar", new int[] {2,0 } },
        { "milk", new int[] {1,0 } },
    };

    private Dictionary<string, int[]> frostingIngridients = new Dictionary<string, int[]>() {
        { "water", new int[] {3,0 } },
        { "sugar", new int[] {2,0 } },
        { "strawberries", new int[] {1,0 } }
    };

    public GameObject BigSpoon;
    public GameObject SmallSpoon;

    public GameObject dough;
    public GameObject doughUp4Grabs;

    public GameObject formInOven;
    public GameObject bakedCake;


    public Dictionary<string, int[]> GetIngredients()
    {
        switch(currentStep)
        {
            case 0: return doughIngridients;
            case 1: return frostingIngridients;
            default: return new Dictionary<string, int[]>();
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

}


