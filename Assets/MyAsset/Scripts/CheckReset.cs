using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckReset : MonoBehaviour
{

    public float xMin = -10;
    public float xMax = 10;
    public float yMin = -100;
    public float yMax = 100;
    public float zMin = -20;
    public float zMax = 20;
    public float initialSpeedX = -10;
    public float initialSpeedY = -10;
    public float initialSpeedZ = -10;

    Vector3 initialPos;

    // Use this for initialization
    void Start()
    {
        Transform trans = GetComponent<Transform>();
        initialPos = trans.position;

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(initialSpeedX, initialSpeedY, initialSpeedZ);
    }

    // Update is called once per frame
    void Update()
    {
        float x, y, z;
        Transform trans = GetComponent<Transform>();
        x = trans.position.x;
        y = trans.position.y;
        z = trans.position.z;

        if ((x < xMin) || (x > xMax) || (y < yMin) || (y > yMax) || (z < zMin) || (z > zMax))
        {
            Debug.Log("OutSide");
            trans.position = initialPos;

            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(initialSpeedX, initialSpeedY, initialSpeedZ);
        }

    }
}
