using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyAnimations : MonoBehaviour
{
    private SpriteRenderer _mySpriteRenderer;
    public Sprite[] frames;
    private int _countFrame;
    private bool _shoots;
    public int animationSpeed;


    void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
        _shoots = false;
    }

    void Update()
    {
        if (_shoots)
        {
            _mySpriteRenderer.sprite = frames[_countFrame / animationSpeed];
            _countFrame++;
        }
        else
            _mySpriteRenderer.sprite = frames[0];
        if (_countFrame == animationSpeed * frames.Length)
        {
            _countFrame = 0;
            _shoots = false;
        }
    }

    public void Shoot()
    {
        _shoots = true;
    }

  
}
