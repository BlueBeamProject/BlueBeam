using System;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private SpriteRenderer _mySpriteRenderer;
    public ParticleSystem dust;
    public Sprite[] frames;
    private bool _run;
    private bool _idle;
    private bool _jump;
    private bool _slide;
    private int _countFrame;
    public int animationSpeed;
    

    void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
        Run();
    }

    void Update()
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

    public void CreateDust()
    {
        dust.Play();
    }
}