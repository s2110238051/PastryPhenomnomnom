using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLimits : MonoBehaviour
{ 
    public void CheckLimits()
    {
        //Debug.Log("checking: " + transform.eulerAngles.x);
        if (this.transform.rotation.eulerAngles.x >= 180)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
            Debug.Log("Runier en Ofen nd heast!!");
        }
    }
}
