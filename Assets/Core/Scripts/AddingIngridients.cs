using Oculus.Interaction;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI.Table;

public class AddingIngridients : MonoBehaviour
{
    //public Collider Flour;
    public ParticleSystem particleSystem;
    public GameObject dough;
    public int counter = 0;
    private AudioSource audioSauce;
    private bool setToppingMix;

    public GameObject toppingObj;

    // ingredient tag, [soll wert, ist wert]

    public RecipeObject recipe;

    private void Start()
    {
        audioSauce = GetComponent<AudioSource>();

        recipe = GameObject.Find("RecipeData").GetComponent<RecipeObject>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("collision with on trigger" + other.name);
        if (recipe.GetIngredients().ContainsKey(other.gameObject.tag))
        {
            if (recipe.currentStep == 1) recipe.SetStep(2); 
            if (recipe.currentStep == 6) recipe.SetStep(7);

            Debug.Log("this ingredient has entered the chat: " + other.gameObject.tag);
            recipe.GetIngredients()[other.gameObject.tag][1]++;

            if (recipe.GetIngredients()[other.gameObject.tag][1] <= recipe.GetIngredients()[other.gameObject.tag][0])
            {
                particleSystem.Play();
                //audioSauce2.Play();
            }
            else
            {
                Debug.Log("womp womp womp");
                audioSauce.Play();
                other.gameObject.GetComponent<Renderer>().material.color = Color.red;
            }

            Destroy(other.gameObject, 1);
            AddDough();
        }
        else if (other.gameObject.CompareTag("spoon"))
        {
            if(setToppingMix)
            toppingObj.SetActive(true);
            dough.SetActive(false);
            recipe.SetStep(9);

        }
        //particleSystem.SetActive(true);
    }

    private void AddDough()
    {
        if(recipe.currentStep >= 3 & !setToppingMix)
        {
            dough = recipe.toppingMix;
            setToppingMix = true;
        }

        if (!dough.activeSelf)
        {
            dough.SetActive(true);
        }
        else
        {
            if (counter < 3)
            {
                dough.transform.localScale += new Vector3(0, 0, 0.2f);
            }

                dough.transform.localPosition += new Vector3(0, 0.1f, 0);
        }
        counter++;
    }

    
}
