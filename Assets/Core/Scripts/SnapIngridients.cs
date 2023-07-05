using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapIngridients : MonoBehaviour
{
    public RecipeObject recipe;

    // Start is called before the first frame update
    void Start()
    {
        recipe = GameObject.Find("RecipeData").GetComponent<RecipeObject>();
        ObjTobePlaced.transform.SetPositionAndRotation(ObjPlaced.transform.position, ObjPlaced.transform.rotation);
    }

    public GameObject ObjTobePlaced; // hover mat
    public GameObject ObjPlaced;
    public bool IsPlaced;
    public bool IsTriggered;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ObjTobePlaced && !IsPlaced)
        {
            //this.gameObject.GetComponent<MeshRenderer>().enabled = true;
            ObjPlaced.SetActive(false);
            IsTriggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == ObjTobePlaced)
        {
            //this.gameObject.GetComponent<MeshRenderer>().enabled = false;

            ObjPlaced.SetActive(true);
            IsTriggered = false;
            IsPlaced = false;
        }
    }

    public void DropObj()
    {
        if (IsTriggered && !IsPlaced)
        {
            //ObjPlaced.SetActive(false);
            //this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            ObjTobePlaced.transform.SetPositionAndRotation(ObjPlaced.transform.position, ObjPlaced.transform.rotation);

            IsPlaced = true;
            IsTriggered = false;

            Debug.Log("Should be placed");
        }
        // on deselect Function => set posiotn
    }

    private void ChangeOutline(Color color)
    {
        ObjPlaced.GetComponent<Outline>().OutlineColor = new Color(1, 1, 0, 1);
    }

    private void HideOutline()
    {
        ObjPlaced.GetComponent<Outline>().OutlineColor = new Color(0, 0, 0, 0);
    }
}
