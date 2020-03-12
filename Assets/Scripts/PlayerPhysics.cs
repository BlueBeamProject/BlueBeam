using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    public float jumpForce;
    public float moveSpeed;
    
    public float dashSpeed;
    public float startDashTime;
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

    public void Dash(int direction)
    {
        timer = DashTimer;
        startTimer = Time.time;
        dashTime = startDashTime;
        _myAnimations.Dash();
        vitesseX = _velocity.x;
        vitesseY = _velocity.y;
        _direction = direction;

        if (dashTime <= 0)
            _direction = 0;
        else
        {
            do
            {
                dashTime -= Time.time;
                if (_direction == 1)
                {
                    _velocity.x = -5000*dashSpeed;
                }
                else if (_direction == 2)
                {
                    _velocity.x = 5000 * dashSpeed;
                }
                else if (_direction == 3)
                {
                    _velocity.y = 5000*dashSpeed;
                }
                else if (_direction == 4)
                {
                    _velocity.y = -5000*dashSpeed;
                }
            }
            while (startTimer - Time.time < timer);
            _velocity.y = vitesseY;
            _velocity.x = vitesseX;
        }
    }

    public void StopDash()
    {
        _direction = 0;
        dashTime = 0;
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
