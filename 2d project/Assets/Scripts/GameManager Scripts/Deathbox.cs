﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathbox : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other)
	{
        if(other.name == "pc") {
            Debug.Log("Player Enters Death Zone");
            Destroy(other);
        }
	}


}


 