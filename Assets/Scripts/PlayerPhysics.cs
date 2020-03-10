using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    private Transform position;
    private int gravity;
    public Vector2 velocity;
    public bool grounded;
    public int jumpForce;
    public int moveSpeed;
    public Collider2D myCollider;
    public LayerMask whatIsGround;
    public Collider2D myCollider2;

    
    
    // Start is called before the first frame update
    void Start()
    {
        this.gravity = 5;
        this.velocity = new Vector2(0,0);
        this.position = GetComponent<Transform>();
        this.jumpForce = 0;
        this.moveSpeed = 2;
        this.myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
        Physics2D.IgnoreCollision(myCollider, myCollider2, false);


        velocity.y += gravity;
        velocity.x += moveSpeed;
        velocity.y -= jumpForce;
        if (grounded)
            velocity.y = 0;
        else if (jumpForce > 0)
        {
            jumpForce--;
        }

        position.Translate(velocity.x,velocity.y,0);
    }
}
