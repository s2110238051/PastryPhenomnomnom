using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static MouseLook;

public class stir : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform rotationPoint;
    public Vector3 rotationAxis = new Vector3(0, 1, 0);
    private Vector3 currentDir;
    private Vector3 lastDir = new Vector3(0,0,0);

    private float rotationTotal;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 v3Velocity = rb.velocity;

        
        if (v3Velocity.magnitude > 0)
        {
            Debug.Log(v3Velocity.magnitude);
            Debug.Log("go brr");
        }

        Vector3 controllerPosition = this.transform.position;
        

        currentDir = Vector3.ProjectOnPlane(rotationPoint.position - controllerPosition, rotationAxis);

        float curAngle = Vector3.Angle(lastDir, currentDir);
        Vector3 crossProd = Vector3.Cross(lastDir, currentDir);

        float d = Vector3.Dot(crossProd, rotationAxis);

        rotationTotal += Mathf.Sign(d) * curAngle;

        lastDir = currentDir;
        Debug.Log(rotationTotal);

        Debug.DrawRay(rotationPoint.position, Vector3.up * (rotationTotal / 360f));
    }
}
