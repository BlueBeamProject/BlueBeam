using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public ParticleSystem dust;

    public float moveSpeed;

    public float jumpForce;

    private Rigidbody2D myRigidbody;

    public bool grounded;

    public LayerMask whatIsGround;

    private Collider2D myCollider;
    
    private Animator myAnimator;

    public int PlayerID = 1;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        myAnimator = GetComponent<Animator>();
    }

	void CreateDust()
	{
		dust.Play();
	}

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) || OnPressButton("DownButton",PlayerID))
        {
            if (grounded)
            {
				CreateDust();
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                Debug.Log("test");
            }
        }

        myAnimator.SetFloat("Speed", myRigidbody.velocity.x);
        myAnimator.SetBool("Grounded", grounded);
        
        
        
        
    }
    
    public bool OnPressButton(string Button,int PlayerID)
    {
        if (Input.GetButtonDown(Button + "P" + PlayerID))
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public float OnTriggerAxis(string Axis, int PlayerID)
    {
        return Input.GetAxis(Axis + "P" + PlayerID);
    }
}
