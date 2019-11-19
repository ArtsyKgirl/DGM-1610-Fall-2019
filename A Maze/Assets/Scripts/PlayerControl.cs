using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 20.0f;
    private Rigidbody playerRb;
   // private float zBound = 39f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.back * speed * verticalInput);
        playerRb.AddForce(Vector3.left * speed * horizontalInput);

     //   if (transform.position.z < -zBound)
     //   {
     //       transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
     //   }
     //   if (transform.position.z > zBound)
     //   {
     //       transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
     //   }
    }
}
