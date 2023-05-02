using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereRotation : MonoBehaviour
{

    public float speed = 0.1f;

    private bool isRotate = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isRotate == true)
        {
            transform.Rotate(Vector3.up * speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(1);
        if (other.transform.CompareTag("Player"))
        {
            isRotate = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            isRotate = true;
        }
    }
}
