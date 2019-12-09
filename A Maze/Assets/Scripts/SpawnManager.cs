using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Prefab;
<<<<<<< HEAD
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
=======
>>>>>>> master
    private float spawnRangeX = 102;
    private float spawnPosZ = 37;
    private float startDelay = 30;
    private float spawnInterval = 2f;
<<<<<<< HEAD
=======
    private float spawnRangeX = 32;
    private float spawnPosZ = 37;
    private float startDelay = 20;
    private float spawnInterval = 1f;
>>>>>>> A Maze fix
=======
>>>>>>> master

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
<<<<<<< HEAD
<<<<<<< 7abcb3c41ee95f1302354cd7fdb3f4316cb56ed9
        Vector3 spawnPos = new Vector3(Random.Range(168f, spawnRangeX), 0, Random.Range(-spawnPosZ, spawnPosZ));
=======
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnPosZ, spawnPosZ));
>>>>>>> A Maze fix
=======
        Vector3 spawnPos = new Vector3(Random.Range(168f, spawnRangeX), 0, Random.Range(-spawnPosZ, spawnPosZ));
>>>>>>> master

        Instantiate(Prefab[cubeIndex], spawnPos, Prefab[cubeIndex].transform.rotation);
    }
}
