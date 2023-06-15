using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;
using static MouseLook;

public class Stir : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject first;

    private Color[] colors =
    {
        new Color(255,0,0),
        new Color(0,255,0),
        new Color(0,0,255)
    };
    private int[] progress = new int[4];
    private int counter = 1;
    

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        //Debug.Log("Stirred: " + collision.gameObject.name);

        if (collision.gameObject == first)
        {       
            Debug.Log("Stirred: "+ collision.gameObject.name);
            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
