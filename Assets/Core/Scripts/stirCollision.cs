using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class stirCollision : MonoBehaviour
{
    public Collider Spoon;


    protected Color[] colors =
    {
        Color.yellow,
        Color.blue,
        Color.cyan,
        Color.magenta,
        Color.green
    };
    protected static int next = 1;
    protected int counter = 0;

    public GameObject IngredientsCounter;
    public RecipeObject recipe;


    // Start is called before the first frame update
    void Start()
    {
        recipe = GameObject.Find("RecipeData").GetComponent<RecipeObject>();
    }

    protected void OnTriggerEnter(Collider other)
    {

        //Debug.Log("collision with on trigger" + other.name);

        if (recipe.currentStep == 2)
        {
            if (other.gameObject == Spoon.gameObject && int.Parse(this.name) == next && counter < colors.Length)
            {
                Debug.Log(this.name + " collided with " + other.gameObject.name);
                this.gameObject.GetComponent<Outline>().OutlineColor = colors[counter];
                //counter = (counter==2) ? 0 : counter+1;
                counter++;
                next = (next == 4) ? 1 : next + 1;
            }
            
            if (int.Parse(this.name) == 4 && counter == colors.Length)
            {
                Finish();
            }
        }
    }

    protected void Finish()
    {
        //step++
        recipe.SetStep(3);
        //reset for next stir event
    }
}
