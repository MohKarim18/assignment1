using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementss : MonoBehaviour
{
    public float movementSpeed = 0.001f;

    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime;
    }
}
