using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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
    public string scene;

    private Rigidbody2D _myBody;
    private Transform _transform;
    private PlayerAnimations _myAnimations;
    private bool _grounded;
    private Vector3 _movement;
    private bool _isSliding;
    private float _startTime;
    private bool _dead;
    private float baseMoveSpeed;
    private ShieldAnimation _myShieldAnimation;
    private bool _canDash;
    private static bool dashOnWall;
    private BoxCollider2D _weapon;

    // Start is called before the first frame update
    void Start()
    {
        _myBody = GetComponent<Rigidbody2D>();
        _myAnimations = GetComponent<PlayerAnimations>();
        _transform = GetComponent<Transform>();
        _weapon = attack.GetComponent<BoxCollider2D>();
        _movement = new Vector3(moveSpeed, 0, 0);
        _isSliding = false;
        _startTime = 0;
        _dead = false;
        baseMoveSpeed = moveSpeed;
        _weapon.enabled = false;
        _myShieldAnimation = GetComponentInChildren<ShieldAnimation>();
        _canDash = true;
        
        SaveData.WriteValueInt("PlayerInGame",SaveData.ReadValueInt("PlayerInGameMemorie"));

        if (SaveData.ReadValueInt("PlayerInGameMemorie") == 1)
        {
            SaveData.AddValueInt("SoloGame",1);
        }
        else
        {
            SaveData.AddValueInt("MultiGame",1);
        }
        
        shield = false;

        if (SaveData.ReadValueInt("Shield") > 0)
        {
            _myShieldAnimation.ShieldAn();
            shield = true;
            SaveData.AddValueInt("Shield", -1);
            Console.WriteLine("shield on");
        }




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
                if (_grounded && !_weapon.enabled)
                    _myAnimations.Run();
                else if (!_weapon.enabled)
                    _myAnimations.Jump();
            }
        }
    }

    public void Jump()
    {
        if (_grounded && !_dead)
        {
            
            SaveData.AddValueInt("JumpTime", 1);
            _myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            _myAnimations.CreateDust();
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
            SaveData.AddValueInt("DoSlide", 1);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _grounded = true;
        }
        if ((collision.gameObject.CompareTag("Obstacle") && !shield) || collision.gameObject.CompareTag("Laser") || (collision.gameObject.CompareTag("Ennemy") && !shield))
        {
            if (_dead == false)
            {
                Die();
            }
        }
        else if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Ennemy"))
        {
            _myShieldAnimation.StopShieldAn();
            Shield();
            SaveData.AddValueInt("ShieldDestroy", 1);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
          _grounded = false;
    }


    public void Die()
    {
        
        SaveData.AddValueInt("DeathTime",1);
        SaveData.AddValueInt("PlayerInGame",-1);

        _dead = true;
        _myAnimations.Die();
        
        if (SaveData.ReadValueInt("PlayerInGame") == 0)
        {
            Instantiate(death, transform.position, Quaternion.identity);
            CameraController.Death();
            QuadController.Death();
            PreLaserScript.Death();
            Money.Death();
            StartCoroutine("wait");
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(scene);
    }

    public void Attack()
    {
        _myAnimations.Attack();
        _weapon.enabled = true;
        StartCoroutine("attackTime");
    }

    IEnumerator attackTime()
    {
        yield return new WaitForSeconds(0.3f);
        _weapon.enabled = false;
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
            SaveData.AddValueInt("UseDash", 1);
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
