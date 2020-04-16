using System;
using TMPro;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private SpriteRenderer _mySpriteRenderer;
    public ParticleSystem dust;
    public Sprite[] frames;
    public Sprite[] slideFrames;
    public Sprite[] attackFrames;
    private bool _run;
    private bool _idle;
    private bool _jump;
    private bool _slide;
    private bool _attack;
    private bool _die;
    private int _countFrame;
    private int _countSlideFrame;
    private int _countAttackFrame;
    public int animationSpeed;


    void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
        _countFrame = 0;
        Run();
    }

    void Update()
    {
        if (!_die)
        {
            if (_run)
            {
                _mySpriteRenderer.sprite = frames[_countFrame / animationSpeed];
                if (_countFrame < animationSpeed * frames.Length - 1)
                    _countFrame++;
                else
                    _countFrame = 0;
            }

            if (_idle)
                _mySpriteRenderer.sprite = frames[1];

            if (_jump)
                _mySpriteRenderer.sprite = frames[0];

            if (_slide)
            {
                _mySpriteRenderer.sprite = slideFrames[_countSlideFrame];
                if (_countSlideFrame < 2)
                    _countSlideFrame++;
            }

            if (_attack)
            {
                _mySpriteRenderer.sprite = attackFrames[_countAttackFrame/2];
                if (_countAttackFrame < 4)
                    _countAttackFrame++;
            }
        }
    }

    public void Run()
    {
        _run = true;
        _idle = false;
        _jump = false;
        _slide = false;
        _attack = false;
    }

    public void Jump()
    {
        _run = false;
        _idle = false;
        _jump = true;
        _slide = false;
        _attack = false;
    }

    public void Idle()
    {
        _run = false;
        _idle = true;
        _jump = false;
        _slide = false;
        _attack = false;
    }

    public void Slide()
    {
        _run = false;
        _idle = false;
        _jump = false;
        _slide = true;
        _attack = false;
        _countSlideFrame = 0;
    }
    
    public void Attack()
    {
        _run = false;
        _idle = false;
        _jump = false;
        _slide = false;
        _attack = true;
        _countAttackFrame = 0;
    }

    public void Die()
    {
        _die = true;
        _mySpriteRenderer.enabled = false;
    }

    public void CreateDust()
    {
        dust.Play();
    }
}