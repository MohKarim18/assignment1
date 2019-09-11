using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public float speed = 1;
    int randomCube;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RandomInteger();
        Cube();
        MoveScreen();
    }

    void RandomInteger()
    {
        randomCube = Random.Range(-10, 11);
    }

    void Cube()
    {
        transform.position = new Vector3(randomCube, transform.position.y, 0);
    }

    void MoveScreen()
    {
       
        transform.position += Vector3.down * speed * Time.time;
    }
}


