using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyAnimations : MonoBehaviour
{
    private SpriteRenderer _mySpriteRenderer;
    private LaserShotAnimations _myLaser;
    public Sprite[] frames;
    private int _countFrame;
    private bool _shoots;
    public int animationSpeed;


    void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
        _myLaser = GetComponentInChildren<LaserShotAnimations>();
        _shoots = false;
    }

    void Update()
    {
        if (_shoots)
        {
            _mySpriteRenderer.sprite = frames[_countFrame / animationSpeed];
            _countFrame++;
            _myLaser.Activate();
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
