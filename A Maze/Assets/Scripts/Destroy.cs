using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destroy : MonoBehaviour
{
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
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
=======
    public float delay = 5.0f;
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {

>>>>>>> A Maze fix
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
        
=======

>>>>>>> Finished Maze
=======
        Destroy(Prefab, delay);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            DestroyImmediate(gameObject, true);

        }
>>>>>>> A Maze fix
    }

    //public void DestroyObjectDelayed()
    //{
      //  Destroy(Prefab);
    //}
}
