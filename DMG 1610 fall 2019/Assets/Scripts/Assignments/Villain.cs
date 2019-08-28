using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villain : MonoBehaviour
{
    string firstName="loki";
    int age = 1048;
    float height = 6.4f;
    bool powers = true;


    
    void Start()
    {
        Debug.Log("First Name: " + firstName);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Powers: " + powers);
    }

  
}
