﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 15.0f;
    private Rigidbody playerRb;
<<<<<<< HEAD
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
    private float zBound = 39f;
=======
=======
>>>>>>> master
    private float zBound = 38.50f;
    //Game Manager
    private GameManager gameManager;

<<<<<<< HEAD
>>>>>>> Finished Maze
=======
    private float zBound = 38.50f;

>>>>>>> A Maze fix
=======
>>>>>>> master
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
<<<<<<< HEAD

        horizontalInput *= Time.deltaTime;
        verticalInput *= Time.deltaTime;

<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
        playerRb.AddForce(Vector3.back * speed * verticalInput);
        playerRb.AddForce(Vector3.left * speed * horizontalInput);

       if (transform.position.z < -zBound)
=======
       if (transform.position.z < -74f)
>>>>>>> Finished Maze
=======
        //playerRb.AddForce(Vector3.forward * speed * verticalInput);
        //playerRb.AddForce(Vector3.right * speed * horizontalInput);

       if (transform.position.z < -74f)
>>>>>>> A Maze fix
=======

        horizontalInput *= Time.deltaTime;
        verticalInput *= Time.deltaTime;

       if (transform.position.z < -74f)
>>>>>>> master
       {
           transform.position = new Vector3(transform.position.x, transform.position.y, -74f);
       }
       if (transform.position.z > zBound)
       {
           transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
       }

<<<<<<< HEAD
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
=======
=======
>>>>>>> master
        transform.Translate(0, 0, -verticalInput);
        transform.Rotate(0, horizontalInput * speed, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.CompareTag("Enemy");
        gameManager.GameOver();

        gameManager.Finished();
<<<<<<< HEAD
>>>>>>> Finished Maze
=======
        transform.Translate(0, 0, -verticalInput);
        transform.Rotate(0, horizontalInput * speed, 0);

        //if(player at the y coordinates of cube1 or cube2... cube10)
        /*
            cube.setgravity(1);
         */
>>>>>>> A Maze fix
=======
>>>>>>> master
    }
}
