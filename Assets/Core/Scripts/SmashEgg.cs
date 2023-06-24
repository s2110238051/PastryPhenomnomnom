using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SmashEgg : MonoBehaviour
{
    //public GameObject SpawnEgg;
    public bool cracked;
    public Transform myChildObject;
    private bool notDone = true;
    private AudioSource audioSauce;
    public AudioClip audioEgg;
    // Start is called before the first frame update
    void Start()
    {
        audioSauce = GetComponent<AudioSource>();
        //audioSauce.Play();
        //audioSauce.clip = audioEgg;
        //audioSauce.Play();
    }

    //private void OnCollisionEnter(Collision collision)
    //{

    //    if (collision.gameObject.CompareTag("bowl") && notDone)
    //    {

    //        notDone = false;
    //        Debug.Log("egg touch");
    //        myChildObject.parent = null;
    //        this.gameObject.SetActive(false);
    //        Rigidbody gameObjectsRigidBody = myChildObject.gameObject.AddComponent<Rigidbody>(); // Add the rigidbody.
    //        myChildObject.gameObject.tag = "eggs";
    //        audioSauce.Play();

    //        Destroy(myChildObject.gameObject, 1);
    //    }
    //}

    public void DeleteShell()
    {
        Debug.Log("egg touch vol 2");
        myChildObject.parent = null;
        this.gameObject.SetActive(false);
        Rigidbody gameObjectsRigidBody = myChildObject.gameObject.AddComponent<Rigidbody>(); // Add the rigidbody.
        myChildObject.gameObject.tag = "eggs";
        audioSauce.Play();

        Destroy(myChildObject.gameObject, 1);
    }
}
