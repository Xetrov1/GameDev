using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPatrol : MonoBehaviour {
    // movement variables
    public float moveSpeed;

    public bool moveRight;

    // wall check
    public Transform wallCheck;

    public float wallcheckRadius;

    public LayerMask whatisWall;

    private bool hittingWall;
    // Edge Check
    private bool notanEdge;

    public Transform edgeCheck;

	// Update is called once per frame // add ground to code
	void Update () {
        notanEdge = Physics2D.OverlapCircle(edgeCheck.position, wallcheckRadius, whatisWall);

        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallcheckRadius, whatisWall);

        if(hittingWall || !notanEdge) {
            moveRight = !moveRight;
        }
        if (moveRight) {
            transform.localScale = new Vector3(-5.5f, 5.5f, 5.5f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        } // 
        else
        {
            transform.localScale = new Vector3(5.5f, 5.5f, 5.5f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }


	}//          __
} //   __________||__
//    /              \
//   /    _      _    \
//   |   |_|    |_|   |
//   |       ___      |  
//   |_______| |______| 