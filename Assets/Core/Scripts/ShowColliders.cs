using Oculus.Interaction;
using Oculus.Interaction.Grab;
using Oculus.Interaction.GrabAPI;
using Oculus.Interaction.HandGrab;
using Oculus.Interaction.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowColliders : MonoBehaviour
{
    private GameObject Colliders;
    public HandGrabInteractor hg;
    // Start is called before the first frame update

    public void Start()
    {

        Colliders = GameObject.Find("StirrColliders");
        Colliders.SetActive(false);
    }

    public void Update()
    {
        //if( InteractorState.Select == hg.State)
        //{
        //     Debug.Log("hiiiiiiiiiii");
        //    if (hg.Interactable.gameObject.CompareTag("spoon")) //InteractorState.Select == hg.State)
        //    {
        //        Colliders.SetActive(true);
        //        Debug.Log(hg.HandGrabTarget);
               
        //    }
        //}
        
       //if (hg.)
       // {
       //     LetsShowColliders();
       //     Colliders.SetActive(true);
       // }
       //else
       // {
       //     Colliders.SetActive(false);
       //     Debug.Log("oh no");
       // }
       //IsHandPinchGrabbing
    }

    public void LetsShowColliders()
    {
        Debug.Log("hiiiiiiiiiii");
        //Colliders = GameObject.Find("StirrColliders");
        Colliders.SetActive(true);
    }

    public void LetsHideColliders()
    {
        Colliders.SetActive(false);
    }
}
