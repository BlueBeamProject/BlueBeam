using System;
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
    public BoxCollider2D[] colliders;
    public GameObject follow;
    public GameObject attack;

    private Rigidbody2D _myBody;
    private Transform _transform;
    private PlayerAnimations _myAnimations;
    private bool _grounded;
    private SoundManager _soundManager;
    private Vector3 _movement;
    private bool _isSliding;
    private float _startTime;
    private bool _dead;
    private float baseMoveSpeed;
    private bool shield;
    private ShieldAnimation sA;
    private bool shieldTimer;

    // Start is called before the first frame update
    void Start()
    {
        _myBody = GetComponent<Rigidbody2D>();
        _myAnimations = GetComponent<PlayerAnimations>();
        _soundManager = GetComponent<SoundManager>();
        _transform = GetComponent<Transform>();
        _movement = new Vector3(moveSpeed, 0, 0);
        _isSliding = false;
        _startTime = 0;
        _dead = false;
        baseMoveSpeed = moveSpeed;
        attack.SetActive(false);
        shield = false;
        sA = GetComponent<ShieldAnimation>();
        shieldTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_dead)
        {
            if (follow.transform.position.x > transform.position.x)
                moveSpeed = baseMoveSpeed + 1;
            else
                moveSpeed = baseMoveSpeed;
            _transform.position += _movement * Time.deltaTime * moveSpeed;
            if (_isSliding)
            {
                if (Time.time - _startTime > slideTime)
                    _isSliding = false;
            }
            else
            {
                colliders[0].enabled = true;
                colliders[1].enabled = false;
                if (_grounded)
                    _myAnimations.Run();
                else
                    _myAnimations.Jump();
            }
        }
    }

    public void Jump()
    {
        if (_grounded && !_dead)
        {
            _myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            _myAnimations.CreateDust();
            _soundManager.Jump();
        }
    }

    public void Slide()
    {
        if (_grounded && !_isSliding && !_dead)
        {
            _isSliding = true;
            colliders[0].enabled = false;
            colliders[1].enabled = true;
            _startTime = Time.time;
            _myAnimations.Slide();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _grounded = true;
            _soundManager.Land();
        }

        if ((collision.gameObject.CompareTag("Obstacle") && !shield) || collision.gameObject.CompareTag("Laser") || (collision.gameObject.CompareTag("Ennemy") && !shield))
        {
            Die();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            _grounded = false;
        
    }

    public void Die()
    {
        _dead = true;
        Instantiate(death, transform.position, Quaternion.identity);
        CameraController.Death();
        QuadController.Death();
        PreLaserScript.Death();
        _myAnimations.Die();
        StartCoroutine("wait");
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Level1");
    }

    public void Attack()
    {
        _myAnimations.Attack();
        attack.SetActive(true);
        StartCoroutine("attackTime");
    }

    IEnumerator attackTime()
    {
        yield return new WaitForSeconds(0.3f);
        attack.SetActive(false);
        _myAnimations.Run();
    }

    public void Shield()
    {
        if (shieldTimer)
        {
            shield = true;
            shieldTimer = false;
            ShieldAnimation.ShildAn();
            StartCoroutine("shieldTime");
        }
    }

    IEnumerator shieldTime()
    {
        yield return new WaitForSeconds(1.5f);
        shield = false;
        yield return new WaitForSeconds(2.5f);
        shieldTimer = true;
    }
}
