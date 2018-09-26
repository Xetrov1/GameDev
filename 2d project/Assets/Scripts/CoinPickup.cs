using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CoinPickup : MonoBehaviour {

    public int pointsToAdd;

	void OnTriggerEnter2D(Collider2D other)
	{
        if (other.GetComponent<PlayerController>() == null)
            return;

        Scoremanager.addPoints(pointsToAdd);

        Destroy(gameObject);
	}
}

