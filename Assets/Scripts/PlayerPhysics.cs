using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    private Transform position;
    public Rigidbody2D rb;
    private float gravity;
    public Vector2 velocity;
    public bool grounded;
    public bool onJump;
    public int jumpForce;
    public int moveSpeed;

    
    
    // Start is called before the first frame update
    void Start()
    {
        this.gravity = 1f;
        this.velocity = new Vector2(0,0);
        this.position = GetComponent<Transform>();
        this.jumpForce = 20;
        this.moveSpeed = 2;
        
    }

    // Update is called once per frame
    void Update()
    {
        SetVelocity(moveSpeed, 0);

        if (!grounded && !onJump)
        {
            Debug.Log("Gravité");
            //velocity.y -= gravity;
            SetVelocity(moveSpeed, -gravity);
        }

       
        if(Input.GetKeyDown("space") && grounded)
        {
            onJump = true;
            SetVelocity(moveSpeed, jumpForce);
            Debug.Log("bite");
            new WaitForSeconds(2f);
            Debug.Log("2s");
            onJump = false;
        }
        

        /*position.Translate(velocity.x,velocity.y,0);
        if (jumpForce > 0)
            jumpForce--;*/
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

    void SetVelocity(float xVelocity, float yVelocity)
    {
        rb.velocity = new Vector2(0, 0);
        rb.velocity += new Vector2(xVelocity, yVelocity);
    }






}
