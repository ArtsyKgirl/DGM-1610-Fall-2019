﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float fetchRate = 1f;
    private float nextFetch = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFetch)
        {
            nextFetch = Time.time + fetchRate;
            
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
