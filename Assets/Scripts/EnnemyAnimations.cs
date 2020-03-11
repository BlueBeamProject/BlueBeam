using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyAnimations : MonoBehaviour
{
    private SpriteRenderer _mySpriteRenderer;
    public ParticleSystem dust;
    public Sprite[] frames;
    private bool _run;
    private bool _idle;
    private bool _jump;
    private int _countFrame;
    public int animationSpeed;


    void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
         _mySpriteRenderer.sprite = frames[_countFrame / animationSpeed];
         _countFrame++;
         if (_countFrame == animationSpeed * frames.Length)
         _countFrame = 0;
    }

    public void CreateDust()
    {
        dust.Play();
    }
}
