using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SmashEgg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.tag.Equals("bowl") == true)
        {
            Debug.Log("egg touch");
        }
    }

    
}
