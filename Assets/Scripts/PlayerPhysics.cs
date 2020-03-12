﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    public PlayerController thePlayer;
    public float jumpForce;
    public float moveSpeed;

    public float dashSpeed;
    public float DashTimer;
    public float jumpTime;

    private Rigidbody2D _myBody;
    private PlayerAnimations _myAnimations;
    private Vector2 _velocity;
    private bool grounded;
    private bool _isJumping;
    private bool _isDashing;
    private SoundManager _soundManager;
    private float dashTime;

    private float jumpTimeCounter;
    private int _direction;
    private float vitesseX;
    private float vitesseY;
    private float startTimer;
    private float timer;
    public float dashDistance = 103f;

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

        Dash(0);
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
    public void Dash(int yes)
    {
        if (yes == 2) dashDistance = dashDistance * (-1);
        _myAnimations.Dash();
        transform.position = new Vector3(transform.position.x *dashDistance/100, transform.position.y, transform.position.z);
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
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
}
