using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlAudio : MonoBehaviour
{
    private AudioSource audioSauce;

    // Start is called before the first frame update
    void Start()
    {
        audioSauce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("eggSound"))
        {
            Debug.Log("eggSound");
            audioSauce.Play();
        }
    }
}
