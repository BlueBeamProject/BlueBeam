using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    public float jumpForce;
    public float moveSpeed;
    public float jumpTime;
    public float jumpTimeCounter;
    
    private Rigidbody2D _myBody;
    private PlayerAnimations _myAnimations;
    private Vector2 _velocity;
    private bool grounded;
    private bool _isJumping;
    private SoundManager _soundManager;

    // Start is called before the first frame update
    void Start()
    {
        _myBody = GetComponent<Rigidbody2D>();
        _myAnimations = GetComponent<PlayerAnimations>();
        _velocity = new Vector2(moveSpeed, 0);
        _soundManager = GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _velocity.y = 0;
        if (grounded)
            _myAnimations.Run();
        else
            _myAnimations.Jump();
        
        if (_isJumping)
            _velocity.y = jumpForce;

        _myBody.velocity = _velocity;
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
    }

    public void StopJump()
    {
        _isJumping = false;
        jumpTimeCounter = 0;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
            _soundManager.Land();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {    
            grounded = false;
            _soundManager.Jump();
        }
    }
}
