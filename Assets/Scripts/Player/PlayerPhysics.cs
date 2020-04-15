﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPhysics : MonoBehaviour
{
    public PlayerController thePlayer;
    public float jumpForce;
    public float moveSpeed;
    public float slideTime;
    public GameObject death;

    private Rigidbody2D _myBody;
    private BoxCollider2D _myCollider;
    private Transform _transform;
    private PlayerAnimations _myAnimations;
    private bool _grounded;
    private SoundManager _soundManager;
    private Vector3 _movement;
    private bool _isSliding;
    private float _startTime;
    static bool dead;

    // Start is called before the first frame update
    void Start()
    {
        _myBody = GetComponent<Rigidbody2D>();
        _myCollider = GetComponent<BoxCollider2D>();
        _myAnimations = GetComponent<PlayerAnimations>();
        _soundManager = GetComponent<SoundManager>();
        _transform = GetComponent<Transform>();
        _movement = new Vector3(moveSpeed, 0, 0);
        _isSliding = false;
        _startTime = 0;
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!dead)
        {

            _transform.position += _movement * Time.deltaTime * moveSpeed;
            if (_isSliding)
            {
                _myAnimations.Slide();
                if (Time.time - _startTime > slideTime)
                    _isSliding = false;
            }
            if (_grounded)
                _myAnimations.Run();
            else
                _myAnimations.Jump();
        }
    }

    public void Jump()
    {
        if (_grounded && !dead)
        {
            _myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            _myAnimations.CreateDust();
        }

    }

    public void Slide()
    {
        if (_grounded && !_isSliding)
        {
            _isSliding = true;
            // Réduire la hitbox
            _startTime = Time.time;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _grounded = true;
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Die();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _grounded = false;
        }
    }

    public void Die()
    {
        dead = true;
        Instantiate(death, transform.position, Quaternion.identity);
        CameraController.Death();
        PreLaserScript.Death();
        _myAnimations.Die();
        StartCoroutine("wait");
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Level1");
    }
}
