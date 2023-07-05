using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControll : MonoBehaviour
{
    public GameObject buttonpress;
    private Color materialC;

    private bool isPlaying = true;
    public AudioSource audioSauce;

    public void OnPress()
    {
        if(isPlaying)
        {
            materialC = gameObject.GetComponent<MeshRenderer>().material.color;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
            

            audioSauce.Pause();
            isPlaying = false;

        }

        else if(!isPlaying)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = materialC;
            
            audioSauce.Play();
            isPlaying = true;
        }
        
    }
}
