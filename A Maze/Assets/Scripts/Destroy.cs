using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float delay = 5.0f;
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(Prefab, delay);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            DestroyImmediate(gameObject, true);

        }
    }
}
