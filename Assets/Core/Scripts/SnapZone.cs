using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class SnapZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            if (ObjTobePlaced.CompareTag("ovenTrigger"))
            {
                Debug.Log("cake made it in the oven!!");
            }
        }
        // on deselect Function => set posiotn
    }
}
