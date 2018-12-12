using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    // Thing
    public static float pcPositionX;
    // Player Movement variables
    public int Movespeed;
    public int JumpHeight;
    private bool doubleJump;
    // player ground controls
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    public Animator animator;
    // non-stick player
    private float moveVelocity;


    // Use this for initialization
    void Start()
    {
        animator.SetBool("isWalking", false);
        animator.SetBool("isJumping", false);
    }
    // runs before update
    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }
    // Update is called once per frame
    void Update()
    {
        pcPositionX = transform.position.x;
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();
        }

        // double jump code
        if (grounded)
        {
            doubleJump = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && !doubleJump && !grounded)
        {
            Jump();
            doubleJump = true;
        }
        if(Input.GetKeyUp(KeyCode.Space)) {
            animator.SetBool("isJumping", false);
        }
        moveVelocity = 0f;

        // movement  a and d to move side to side
        if (Input.GetKey(KeyCode.D))
        {
            //  GetComponent<Rigidbody2D>().velocity = new Vector2(Movespeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = Movespeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-Movespeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = -Movespeed;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

        if (Input.GetKeyDown(KeyCode.D) || (Input.GetKeyDown(KeyCode.A)))
        {
            moveVelocity = Movespeed;
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKeyUp(KeyCode.D) && (Input.GetKeyUp(KeyCode.A)))
        {
            animator.SetBool("isWalking", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveVelocity = -Movespeed;
            animator.SetBool("isWalking", true);


        // player flip
        if (GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            transform.localScale = new Vector3(0.6f, 0.8f, 1f);
        }
        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            transform.localScale = new Vector3(-0.6f, 0.8f, 1f);
        }

       
        }
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
        animator.SetBool("isJumping", true);
    }


    // 
}
 // 