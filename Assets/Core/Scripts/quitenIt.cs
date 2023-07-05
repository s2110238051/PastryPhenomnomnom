using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitenIt : MonoBehaviour
{
    public GameObject buttonpress;
    private Color materialC;

    public void OnPress()
    {
        Application.Quit();
    }
}
