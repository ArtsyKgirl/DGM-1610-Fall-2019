using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 15.0f;
    private Rigidbody playerRb;
    private float zBound = 38.50f;
    //Game Manager
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //Finding Game Manager
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * speed;
        float verticalInput = Input.GetAxis("Vertical") * speed;

        horizontalInput *= Time.deltaTime;
        verticalInput *= Time.deltaTime;

       if (transform.position.z < -74f)
       {
           transform.position = new Vector3(transform.position.x, transform.position.y, -74f);
       }
       if (transform.position.z > zBound)
       {
           transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
       }

        transform.Translate(0, 0, -verticalInput);
        transform.Rotate(0, horizontalInput * speed, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.CompareTag("Enemy");
        gameManager.GameOver();

        gameManager.Finished();
    }
}
