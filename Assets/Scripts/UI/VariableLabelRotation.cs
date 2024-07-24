using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableLabelRotation : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, 
            Camera.main.transform.rotation * Vector3.up);
    }
}