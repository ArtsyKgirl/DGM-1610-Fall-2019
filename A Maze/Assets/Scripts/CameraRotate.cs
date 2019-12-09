using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public PlayerControl player;
    public Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
        // transform.position = player.transform.position;

        // float horizontalInput = Input.GetAxis("Horizontal");
        // transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
=======
       
>>>>>>> Finished Maze
=======
        
        if(Input.GetKeyDown("a"))
        {
            //Camera following the player. The camera follows playerRb (Rigidbody).
            //What makes logical sense:
            //1. The camera should follow the view of the player
            //2. The camera should not rotate on its X or Z axis. Rotate on the Y.
            //3. The player needs to rotate, but it's should constantly be with the user input.
            //4. Research the point of view.
        }
>>>>>>> A Maze fix
=======
       
>>>>>>> master
    }
}
