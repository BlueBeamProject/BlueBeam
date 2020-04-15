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
        _countFrame = 0;
    }

    void Update()
    {
        _mySpriteRenderer.sprite = frames[_countFrame / animationSpeed];
        if (_countFrame < animationSpeed * frames.Length - 1)
            _countFrame++;
        else
            _countFrame = 0;
    }

    public void Shoot()
    {
        _shoots = true;
    }
}
