using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeStart : MonoBehaviour
{

    public Canvas canvasToClose;
    public GameObject buttonpress;
    private Color materialC;

    public void OnPress()
    {
        materialC = gameObject.GetComponent<MeshRenderer>().material.color;
        gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
        canvasToClose.gameObject.SetActive(false);
    }

    public void OnUnPress()
    {
        Debug.Log("unpressing to move" + this.gameObject.transform.localPosition);
        gameObject.GetComponent<MeshRenderer>().material.color=materialC;
        this.transform.parent.gameObject.SetActive(false);
    }
}
