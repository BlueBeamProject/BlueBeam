using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{

    public Rigidbody2D rb;
    public float vitesse;
    public float maxJump;
    private bool isGrounded = false;
    public int PlayerID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        SetVelocity(ControllerAPI.GetAxis("HorizontalLeft",PlayerID)*Time.deltaTime*vitesse, 0);
        
        

      
        
        if((Input.GetKeyDown("space") || ControllerAPI.GetButton("DownButton",PlayerID)) && isGrounded){
            Jump();
        }
    }

    void Jump()
    {
        
        SetVelocity(0, maxJump*Time.deltaTime*1000);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("bite");
        if (col.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    void SetVelocity(float xVelocity, float yVelocity)
    {
        rb.velocity = new Vector2(0,0);
        rb.velocity += new Vector2(xVelocity, yVelocity);
    }

}
