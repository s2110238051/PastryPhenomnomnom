using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOven : MonoBehaviour
{
    public Light ovenLight;
    private Color materialC;
    private bool turnedOn = false;
    public RecipeObject recipie;

    void Start()
    {
        recipie = GameObject.Find("RecipeData").GetComponent<RecipeObject>();
    }

    public void OnPress()
    {
        //materialC = gameObject.GetComponent<MeshRenderer>().material.color;
        //gameObject.GetComponent<MeshRenderer>().enabled = true;
        recipie.ovenTurnedOn = !recipie.ovenTurnedOn;
        ovenLight.gameObject.SetActive(recipie.ovenTurnedOn);
        if (recipie.ovenTurnedOn)
        {
            recipie.StartOvenTimer();
        }
    }



    public void OnUnPress()
    {
        //Debug.Log("unpressing to move" + this.gameObject.transform.localPosition);
        //gameObject.GetComponent<MeshRenderer>().material.color = materialC;
    }
}
