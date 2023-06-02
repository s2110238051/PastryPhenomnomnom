using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("egg"))
        {;
            //Debug.Log("egg sound");
            //myChildObject.parent = null;
            //audioSauce.Play();
        }
    }
}
