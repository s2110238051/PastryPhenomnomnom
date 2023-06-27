using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class SnapZone : MonoBehaviour
{
    public RecipeObject recipe;

    // Start is called before the first frame update
    void Start()
    {
        recipe = GameObject.Find("RecipeData").GetComponent<RecipeObject>();
    }

    public GameObject ObjTobePlaced;
    public GameObject ObjPlaced;
    public bool IsPlaced;
    public bool IsTriggered;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == ObjTobePlaced && !IsPlaced)
        {
            ObjPlaced.SetActive(true);
            IsTriggered = true;
        }  
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == ObjTobePlaced)
        {
            ObjPlaced.SetActive(false);
            IsTriggered = false;
            IsPlaced = false;
        }
    }

    public void DropObj()
    {
        if(IsTriggered && !IsPlaced)
        {
            //ObjTobePlaced.transform.SetWorldPose(ObjPlaced.transform.GetWorldPose());

            ObjPlaced.GetComponent<MeshRenderer>().material = ObjTobePlaced.GetComponent<MeshRenderer>().material;
            ObjTobePlaced.SetActive(false);
            IsPlaced = true;
            if (ObjTobePlaced.CompareTag("cakeForm"))
            {
                Debug.Log("cake made it in the oven!!");
                recipe.cakeInOven = true;
                recipe.StartOvenTimer();
            } else if (ObjTobePlaced.CompareTag("doughForm"))
            {
                Debug.Log("cake made it on the form!!");
                recipe.SetStep(4);
            }
        }
        // on deselect Function => set posiotn
    }
}
