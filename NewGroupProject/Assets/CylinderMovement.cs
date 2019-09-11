using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour
{

    //float step = Mathf.PI / 60;
    //float timeVar = 0;
    //float rotationRange = 120;
    //float baseDirection = 10;

    //Vector3 randomDirection;
    void Start()
    {

    }
    void Update()
    {

        transform.position = new Vector3(3 * Mathf.Sin(Time.time), 3 * Mathf.Cos(Time.time), 0);

        //randomDirection = new Vector3(10, Mathf.Sin(timeVar) * (rotationRange / 2) + baseDirection, 0);
        //transform.Rotate(randomDirection * Time.deltaTime * 10.0f);
    }
}
