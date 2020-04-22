using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPhysics : MonoBehaviour
{
    public float jumpForce;
    public float moveSpeed;
    public float slideTime;
    public GameObject death;
    public GameObject dash;
    public BoxCollider2D[] colliders;
    public GameObject follow;
    public GameObject prellow;
    public GameObject attack;
    public bool shield;

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
    private ShieldAnimation _myShieldAnimation;
    private bool _canDash;
    private static bool dashOnWall;

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
        _myShieldAnimation = GetComponentInChildren<ShieldAnimation>();
        _canDash = true;
        if (shield)
            _myShieldAnimation.ShieldAn();
        else
            _myShieldAnimation.StopShieldAn();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_dead)
        {
            if (follow.transform.position.x > transform.position.x)
                moveSpeed = baseMoveSpeed + 0.2f;
            else
                if (prellow.transform.position.x < transform.position.x)
                    moveSpeed = baseMoveSpeed - 0.5f;
                else
                    moveSpeed = baseMoveSpeed + 0.2f;
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
            colliders[1].enabled = true;
            colliders[0].enabled = false;
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
        else if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Ennemy"))
        {
            _myShieldAnimation.StopShieldAn();
            Shield();
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
        Money.Death();
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
    }

    public void Shield()
    {
        StartCoroutine("stopshield");
    }

    IEnumerator stopshield()
    {
        yield return new WaitForSeconds(1);
        shield = false;
    }

    public void Dash()
    {
        if (_canDash && !dashOnWall)
        {
            _canDash = false;
            Instantiate(dash, transform.position, Quaternion.identity);
            transform.position += new Vector3(3, 0, 0);
            Instantiate(dash, transform.position, Quaternion.identity);
            StartCoroutine("DashTimer");
        }
    }

    IEnumerator DashTimer()
    {
        yield return new WaitForSeconds(2);
        _canDash = true;
    }

    public static void DashWall(bool yes)
    {
        if (yes)
            dashOnWall = true;
        else
            dashOnWall = false;
    }
}
