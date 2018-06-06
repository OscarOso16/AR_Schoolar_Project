using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer_Input : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(0, Input.acceleration.x, 0);
        transform.Translate(Input.acceleration.x * 10, 0, 0);
    }
}
