using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disney : MonoBehaviour
{
    string firstName="Mickey";
    int age = 83;
    float height = 4.8f;
    bool evil = false;


    
    void Start()
    {
        Debug.Log("First Name: " + firstName);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Evil: " + evil);
    }

  
}
