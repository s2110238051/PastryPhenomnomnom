using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float firepower = 10;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * firepower, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
