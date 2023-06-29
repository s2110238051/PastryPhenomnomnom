using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutStrawberry : MonoBehaviour
{

    public GameObject prefabCutStrawberries;



    public void CutStawberry()
    {
        Debug.Log("cut stawberry");
        Instantiate(prefabCutStrawberries, this.transform.position, this.transform.rotation);
        this.gameObject.SetActive(false);

        //audioSauce.Play();

    }

    private void OnTriggerEnter(Collider other)
    {

        //Debug.Log("collision with on trigger" + other.name);
        if (other.gameObject.CompareTag("knife"))
        {
            CutStawberry();
        }
    }
}
