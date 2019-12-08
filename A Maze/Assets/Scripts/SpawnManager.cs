﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Prefab;
    private float spawnRangeX = 102;
    private float spawnPosZ = 37;
    private float startDelay = 30;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCube", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomCube()
    {
        int cubeIndex = Random.Range(0, Prefab.Length);
        //Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPos = new Vector3(Random.Range(168f, spawnRangeX), 0, Random.Range(-spawnPosZ, spawnPosZ));

        Instantiate(Prefab[cubeIndex], spawnPos, Prefab[cubeIndex].transform.rotation);
    }
}
