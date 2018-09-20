using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathbox : MonoBehaviour {

	private void OnTriggerEnter2D(BoxCollider2D other)
	{
        if(other.name == "spr_pc") {
            Debug.Log("Player Enters Death Zone");
            Destroy(other);
        }
	}


}


// 