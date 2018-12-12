using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float groundCheckRadius;

    public LayerMask whatIsGround;

    private bool grounded;
    public Animator animator;
    public int Movespeed;
    private float moveVelocity;
	// Use this for initialization
	void Start () {
        animator.SetBool("isWalking", false);
        animator.SetBool("isJumping", false);
	}
	
	// Update is called once per frame
	void Update () {

      
	}
}
