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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision with on trigger" + other.name);

        if(other == Flour)
        {
            Debug.Log("flour in se house");
        }

        //particleSystem.SetActive(true);
        particleSystem.Play();
    }
}
