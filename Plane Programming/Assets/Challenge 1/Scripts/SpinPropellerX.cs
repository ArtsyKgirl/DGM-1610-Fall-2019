using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float rotationSpeed = 1000;

    // Update is called once per frame
    void Update()
    {
        //Rotation of Propeller
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
