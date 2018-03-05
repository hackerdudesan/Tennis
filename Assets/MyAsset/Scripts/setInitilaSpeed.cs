using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setInitilaSpeed : MonoBehaviour {

    public float xSpeed = 1;
    public float ySpeed = 1;
    public float zSpeed = 1;

	// Use this for initialization
	void Start () {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce( new Vector3( xSpeed,ySpeed,zSpeed));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
