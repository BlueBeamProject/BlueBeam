using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyAnimations : MonoBehaviour
{
    private SpriteRenderer _mySpriteRenderer;
    private Weapon _myWeapon;

    public Sprite[] frames;
    private int _countFrame;
    private bool _shoots = false;
    private IEnumerator coroutineShoot; 
    


    void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
        _myWeapon = GetComponent<Weapon>();
        _countFrame = 0;
        coroutineShoot = ShootAnimation();
    }

    void Update()
    {
        if (_shoots)
        {
            StartCoroutine(coroutineShoot);
        }
    }

    public void Shoot()
    {
        _shoots = true;
    }

    public void StopShoot()
    {
        Debug.Log("Stop ennemi animation");
        
        StopCoroutine(coroutineShoot);
    }


    private IEnumerator ShootAnimation()
    {
        _shoots = false;

        while (_countFrame < frames.Length)
        {
            
            _mySpriteRenderer.sprite = frames[_countFrame];
            _countFrame++;
            if (_countFrame == 4)
            {
                _myWeapon.StartShoot();
            }
            
            if (_countFrame >= frames.Length)
            {
                _countFrame = 0;
            }
            yield return new WaitForSeconds(0.3f);
        }
        _shoots = true;

    }
}
