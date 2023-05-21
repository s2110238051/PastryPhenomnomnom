using Oculus.Interaction;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI.Table;

public class AddingIngridients : MonoBehaviour
{
    public Collider Flour;
    public ParticleSystem particleSystem;

    // ingredient tag, [soll wert, ist wert]
    private Dictionary<string, int[]> Ingridients = new Dictionary<string, int[]>() {
        { "flour", new int[] {3,0 } },
        { "eggs", new int[] {2,0 } },
        { "sugar", new int[] {2,0 } },
        { "milk", new int[] {1,0 } },
    };

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("collision with on trigger" + other.name);
        if(Ingridients.ContainsKey(other.gameObject.tag))
        {
            Debug.Log("this ingredient has entered the chat: " + other.gameObject.tag);
            Ingridients[other.gameObject.tag][1]++;

            if(Ingridients[other.gameObject.tag][1]<= Ingridients[other.gameObject.tag][0])
            {
                particleSystem.Play();
            }
            else
            {
                Debug.Log("womp womp womp");
            }
        }
        //particleSystem.SetActive(true);
    }

    public bool ValidatePatter()
    {
        bool result = true;
        foreach (string key in Ingridients.Keys)
        {
            if (Ingridients[key][1] != Ingridients[key][0])
                result = false;
        }

        return result;
    }
}
