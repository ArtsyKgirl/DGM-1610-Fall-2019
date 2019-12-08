using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 20.0f;
    private Rigidbody playerRb;
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
    private float zBound = 39f;
=======
    private float zBound = 38.50f;
    //Game Manager
    private GameManager gameManager;

>>>>>>> Finished Maze
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
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
        playerRb.AddForce(Vector3.back * speed * verticalInput);
        playerRb.AddForce(Vector3.left * speed * horizontalInput);

       if (transform.position.z < -zBound)
=======
       if (transform.position.z < -74f)
>>>>>>> Finished Maze
       {
           transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
       }
       if (transform.position.z > zBound)
       {
           transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
       }

<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
=======
        transform.Translate(0, 0, -verticalInput);
        transform.Rotate(0, horizontalInput * speed, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.CompareTag("Enemy");
        gameManager.GameOver();

        gameManager.Finished();
>>>>>>> Finished Maze
    }
}
