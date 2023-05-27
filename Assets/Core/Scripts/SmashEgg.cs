using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SmashEgg : MonoBehaviour
{
    //public GameObject SpawnEgg;
    public Transform myChildObject;
    private bool notDone = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bowl") && notDone)
        {
            notDone = false;
            Debug.Log("egg touch");
            //Destroy(this.gameObject, 1);
            //Instantiate(SpawnEgg, this.transform.position, this.transform.rotation);
            AudioSource audioData = GetComponent<AudioSource>();
            audioData.Play(0);

            myChildObject.parent = null;
            this.gameObject.SetActive(false);
            Rigidbody gameObjectsRigidBody = myChildObject.gameObject.AddComponent<Rigidbody>(); // Add the rigidbody.
            myChildObject.gameObject.tag="eggs";
            //BoxCollider boxCollider = myChildObject.gameObject.AddComponent<BoxCollider>();
            


            //SpawnEgg.transform.position = this.gameObject.transform.position;
            //SpawnEgg.transform.rotation = this.gameObject.transform.rotation;
            //SpawnEgg.SetActive(true);

        }
    }

    
}
