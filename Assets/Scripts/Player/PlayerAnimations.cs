using System;
using TMPro;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private SpriteRenderer _mySpriteRenderer;
    private Transform _transform;
    public ParticleSystem dust;
    public Sprite[] frames;
    private bool _run;
    private bool _idle;
    private bool _jump;
    private bool _slide;
    private bool _die;
    private int _countFrame;
    public int animationSpeed;
    

    void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
        _transform = GetComponent<Transform>();
        Run();
    }

    void Update()
    {
        if (!_die)
        {

            if (_run)
            {
                _mySpriteRenderer.sprite = frames[_countFrame / animationSpeed];
                _countFrame++;
                if (_countFrame == animationSpeed * frames.Length)
                    _countFrame = 0;
            }

            if (_idle)
                _mySpriteRenderer.sprite = frames[1];

            if (_jump)
                _mySpriteRenderer.sprite = frames[0];

            if (_slide)
                _mySpriteRenderer.sprite = frames[0];
        }
    }

    public void Run()
    {
        _run = true;
        _idle = false;
        _jump = false;
        _slide = false;
    }

    public void Jump()
    {
        _run = false;
        _idle = false;
        _jump = true;
        _slide = false;
    }

    public void Idle()
    {
        _run = false;
        _idle = true;
        _jump = false;
        _slide = false;
    }

    public void Slide()
    {
        _run = false;
        _idle = false;
        _jump = false;
        _slide = true;
    }

    public void Die()
    {
        _run = false;
        _idle = false;
        _jump = false;
        _slide = false;
        _die = true;
        _mySpriteRenderer.sprite = frames[1];
        _transform.Rotate(new Vector3(1, 1, 0), 90f);
    }

    public void CreateDust()
    {
        dust.Play();
    }
}