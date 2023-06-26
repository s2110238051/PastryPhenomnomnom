using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOven : MonoBehaviour
{
    public Light ovenLight;
    private Color materialC;
    private bool turnedOn = false;

    public void OnPress()
    {
        //materialC = gameObject.GetComponent<MeshRenderer>().material.color;
        //gameObject.GetComponent<MeshRenderer>().enabled = true;
        turnedOn = !turnedOn;
        ovenLight.gameObject.SetActive(turnedOn); 
    }



    public void OnUnPress()
    {
        //Debug.Log("unpressing to move" + this.gameObject.transform.localPosition);
        //gameObject.GetComponent<MeshRenderer>().material.color = materialC;
    }
}
