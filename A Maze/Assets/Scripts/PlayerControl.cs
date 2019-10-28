using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 40f;
    private float horizontalInput;
    private float forwardInpute;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInpute = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInpute);
        transform.Rotate(Vector3.down, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
