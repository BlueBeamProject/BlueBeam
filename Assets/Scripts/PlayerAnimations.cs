using System;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private SpriteRenderer _mySpriteRenderer;
    public ParticleSystem dust;
    public ParticleSystem dash;
    public Sprite[] frames;
    private bool _run;
    private bool _idle;
    private bool _jump;
    private int _countFrame;
    public int animationSpeed;
    

    void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
        Run();
    }

    void Update()
    {
        _mySpriteRenderer.enabled = true;
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
    }

    public void Run()
    {
        _run = true;
        _idle = false;
        _jump = false;
    }

    public void Jump()
    {
        _run = false;
        _idle = false;
        _jump = true;
    }

    public void Idle()
    {
        _run = false;
        _idle = true;
        _jump = false;
    }

    public void CreateDust()
    {
        dust.Play();
    }

	public void Dash()
	{
        dash.Play();
	}
}