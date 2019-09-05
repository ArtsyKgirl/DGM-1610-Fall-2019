using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Functions : MonoBehaviour
{
    // string firstName;
    // string lastName;
    // int age;

    //Attributes
    int num1;
    int num2;
    int total;

    // Start is called before the first frame update
    void Start()
    {
        // firstName = "Bob";

        // lastName = "Ross";

        // age = 90;

        // Customer(firstName, lastName, age);
        CalcAdd(11, 23);
        CalcSub(23, 15);
        CalcDivide(25, 5);
        CalcMulti(8, 7);
        CalcSqr(6, 2);
        CalcRoot(9);

    }

   int CalcAdd(int n1, int n2)
    {
        Debug.Log("Number 1 = " + n1 + " Number 2 = " + n2);
        total = n1 + n2;
        Debug.Log(total);
        
        return total;
    }

    int CalcSub(int n1, int n2)
    {
        Debug.Log("Number 1 = " + n1 + " Number 2 = " + n2);
        total = n1 - n2;
        Debug.Log(total);

        return total;
    }

    int CalcDivide(int n1, int n2)
    {
        Debug.Log("Number 1 = " + n1 + " Number 2 = " + n2);
        total = n1 / n2;
        Debug.Log(total);

        return total;
    }

    int CalcMulti(int n1, int n2)
    {
        Debug.Log("Number 1 = " + n1 + " Number 2 = " + n2);
        total = n1 * n2;
        Debug.Log(total);

        return total;
    }

    int CalcSqr(int n1, int n2)
    {
        Debug.Log("Number 1 = " + n1 + " Number 2 = " + n2);
        total = (int)Math.Pow(n1, n2);
        Debug.Log(total);

        return total;
    }

    int CalcRoot(int n1)
    {
        Debug.Log("Number = " + n1);
        total = (int)Math.Sqrt(n1);
        Debug.Log(total);

        return total;
    }

    // void Customer(string fName, string lName, int a)
    // {
    //     Debug.Log(fName + " " + lName + " " + a);
    // }
}
