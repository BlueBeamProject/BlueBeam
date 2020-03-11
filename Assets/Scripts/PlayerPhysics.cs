using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
<<<<<<< Updated upstream
    private Transform position;
    public Rigidbody2D rb;
    private float gravity;
    public Vector2 velocity;
    public bool grounded;
    public bool onJump;
    public int jumpForce;
    public int moveSpeed;
=======
    private Rigidbody2D _myBody;
    private PlayerAnimations _myAnimations;
    private Vector2 velocity;
    public bool grounded;
    public float jumpForce;
    public float moveSpeed;
    public float jumpTime;
    public float jumpTimeCounter;
    private bool _isJumping;
>>>>>>> Stashed changes

    
    
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        this.gravity = 1f;
        this.velocity = new Vector2(0,0);
        this.position = GetComponent<Transform>();
        this.jumpForce = 20;
        this.moveSpeed = 2;
        
=======
        _myBody = GetComponent<Rigidbody2D>();
        _myAnimations = GetComponent<PlayerAnimations>();
        velocity = new Vector2(moveSpeed, 0);
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
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
=======
        velocity.y = 0;
        if (grounded)
            _myAnimations.Run();
        else
            _myAnimations.Jump();
        
        if (_isJumping)
            velocity.y = jumpForce;

        _myBody.velocity = velocity;
    }

    public void Jump()
    {
        if (grounded)
        {
            jumpTimeCounter = jumpTime;
            _isJumping = true;
            _myAnimations.CreateDust();
        }

        else if (jumpTimeCounter > 0)
            jumpTimeCounter -= Time.deltaTime;
        
        else
            _isJumping = false;
>>>>>>> Stashed changes
    }

    public void StopJump()
    {
        _isJumping = false;
        jumpTimeCounter = 0;
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
