using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destroy : MonoBehaviour
{
    public GameObject Prefab;
    private Rigidbody playerRb;
    public float DestroyObjectDelayed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //public void DestroyObjectDelayed()
    //{
      //  Destroy(Prefab);
    //}
}
