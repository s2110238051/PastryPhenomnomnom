using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class bowlAudio : MonoBehaviour
{
    private AudioSource audioSauce;
    private GameObject potObj;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        audioSauce = GetComponent<AudioSource>();
        //potObj = this.gameObject;
        potObj = GameObject.FindGameObjectWithTag("bowl");
        //animator = potObj.GetComponent<Animator>();   
    }

    //private void OnCollisionEnter(Collision collision)
    //{

    //    if (collision.gameObject.CompareTag("eggSound"))
    //    {
    //        Debug.Log("eggSound");
    //        audioSauce.Play();
    //    }
    //}

    public void OnEggSelect()
    {

        potObj = GameObject.FindGameObjectWithTag("bowl");
        GameObject.FindGameObjectWithTag("bowl").GetComponent<Outline>().OutlineColor = Color.yellow;

    }

    public void OnEggUnselect(SmashEgg egg)
    {
      
        if (egg.cracked)
        {
            egg.DeleteShell();
        }
        GameObject.FindGameObjectWithTag("bowl").GetComponent<Outline>().OutlineColor = new Color(255, 0, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {

        //Debug.Log("collision with on trigger" + other.name);
        if (other.gameObject.CompareTag("eggSound"))
        {
            audioSauce.Play();
            ChangeOutline(Color.green);
            Invoke("HideOutline", 2);
            other.gameObject.GetComponent<SmashEgg>().cracked = true;
        }
    }


    private void ChangeOutline(Color color)
    {
        this.gameObject.GetComponent<Outline>().OutlineColor = color;  
    }

    private void HideOutline()
    {
        this.gameObject.GetComponent<Outline>().OutlineColor = new Color(255, 0, 0, 0);
    }
}
