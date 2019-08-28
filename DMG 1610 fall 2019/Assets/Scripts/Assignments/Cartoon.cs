using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartoon : MonoBehaviour
{
    string firstName="Bugs";
    int age = 70;
    float height = 3.3f;
    bool animal = true;


    
    void Start()
    {
        Debug.Log("First Name: " + firstName);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Animal: " + animal);
    }

  
}
