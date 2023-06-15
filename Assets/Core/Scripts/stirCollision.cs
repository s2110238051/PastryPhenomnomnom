using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class stirCollision : MonoBehaviour
{
    public Collider BigSpoon;


    private Color[] colors =
    {
        new Color(255,0,0),
        new Color(0,255,0),
        new Color(0,0,255)
    };
    private static int next = 1;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("collision with on trigger" + other.name);
        if (other.gameObject == BigSpoon.gameObject && int.Parse(this.name)==next && counter<2)
        {
            Debug.Log(this.name + " collided with " + other.gameObject.name);
            this.gameObject.GetComponent<Outline>().OutlineColor = colors[counter];
            //counter = (counter==2) ? 0 : counter+1;
            counter++;
            next = (next==4) ? 1 : next+1;
        }
    }
}
