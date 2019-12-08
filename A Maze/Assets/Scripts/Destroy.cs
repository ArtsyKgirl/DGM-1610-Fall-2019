using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destroy : MonoBehaviour
{
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
    // Start is called before the first frame update
    void Start()
    {
        
=======
    public GameObject Prefab;
    private Rigidbody playerRb;
    public float DestroyObjectDelayed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
>>>>>>> Finished Maze
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
        
=======

>>>>>>> Finished Maze
    }

    //public void DestroyObjectDelayed()
    //{
      //  Destroy(Prefab);
    //}
}
