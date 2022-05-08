using System;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        processInput();
    }

    void processInput() 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Pressed Space");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Pressed D");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Pressed A");
        }
    }
}
