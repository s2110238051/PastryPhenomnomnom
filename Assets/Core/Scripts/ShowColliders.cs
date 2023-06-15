using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowColliders : MonoBehaviour
{
    public static GameObject Colliders;
    // Start is called before the first frame update

    public void LetsShowColliders()
    {
        Debug.Log("hiiiiiiiiiii");
        //Colliders.SetActive(true);
    }

    public void LetsHideColliders()
    {
        Colliders.SetActive(false);
    }
}
