using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SmashEgg : MonoBehaviour
{
    public GameObject SpawnEgg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bowl"))
        {
            Debug.Log("egg touch");
            Destroy(this, 1);
            Instantiate(SpawnEgg, this.transform);

        }
    }

    
}
