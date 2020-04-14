using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    public PlayerController thePlayer;
    public float jumpForce;
    public float moveSpeed;

    private Rigidbody2D _myBody;
    private Transform _transform;
    private PlayerAnimations _myAnimations;
    private bool _grounded;
    private SoundManager _soundManager;
    private Vector3 _movement;

    // Start is called before the first frame update
    void Start()
    {
        _myBody = GetComponent<Rigidbody2D>();
        _myAnimations = GetComponent<PlayerAnimations>();
        _soundManager = GetComponent<SoundManager>();
        _transform = GetComponent<Transform>();
        _movement = new Vector3(moveSpeed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        _transform.position += _movement * Time.deltaTime * moveSpeed;
        if (_grounded)
            _myAnimations.Run();
        else
            _myAnimations.Jump();
        
    }

    public void Jump()
    {
        if (_grounded)
            _myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _grounded = false;
        }
    }
}
