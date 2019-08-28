using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    string firstName="Batman";
    int age = 42;
    float height = 6f;
    bool powers = false;


    
    void Start()
    {
        Debug.Log("First Name: " + firstName);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Powers: " + powers);
    }

  
}
