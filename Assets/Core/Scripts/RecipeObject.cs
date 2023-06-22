using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}


