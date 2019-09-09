using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movementSpeed = 10.0f;


    void Update()
        {
            transform.position += Vector3.forward * Time.deltaTime;
        }
    }

