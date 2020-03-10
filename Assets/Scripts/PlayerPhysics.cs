using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    public Transform position;
    public Rigidbody2D rb;
    public Vector2 velocity;
    public bool grounded;
    public float jumpForce;
    public float moveSpeed;
    public float jumpTime;
    public float jumpTimeCounter;
    private bool IsJumping;





    // Start is called before the first frame update
    void Start()
    {
        this.position = GetComponent<Transform>();
        this.jumpForce = 15.0f;
        this.moveSpeed = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(rb.velocity.x + moveSpeed, 0);
        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            IsJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        if (IsJumping && Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
            else if (jumpTimeCounter < 0)
                IsJumping = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
            IsJumping = false;

 
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            grounded = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            grounded = false;
    }







}
