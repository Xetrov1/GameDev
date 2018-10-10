﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pew : MonoBehaviour {

    public float Speed;

    public Rigidbody2D pc;

    public GameObject EnemyDeath;

    public GameObject ProjectileParticle;
    public int PointsforKill;

	// Use this for initialization
	void Start () {
        // Player = FindObjectOfType<Rigidbody2D>();
        if (pc.transform.localScale.x < 0)
            Speed = -Speed;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
	}
	void OnTriggerEnter2D(Collider2D other)
	{
        if(other.tag == "Enemy"){
            Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            Scoremanager.AddPoints(PointsforKill);
        } // ends if
        Instantiate(ProjectileParticle, transform.position, transform.rotation);
        Destroy(gameObject);
    } // ends ontrigger 
}
