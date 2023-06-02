using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 v3Velocity = rb.velocity;

        Debug.Log(v3Velocity);
        if(v3Velocity.magnitude > 1)
        {
            Debug.Log("go brr");
        }
    }
}
