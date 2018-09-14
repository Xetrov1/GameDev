using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        double momentum, speed = 5, range = 15;
        momentum = speed + GetComponent<Rigidbody2D>().velocity.x;
        bool g = false;
        if (g == true && Input.GetKey(KeyCode.Q)) {
            
        }

	}
}
