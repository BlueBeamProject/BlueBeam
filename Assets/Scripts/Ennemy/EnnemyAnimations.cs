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
    public float animspeed;
    


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
            StartCoroutine(ShootAnimation());
        }
    }

    public void Shoot()
    {
        _shoots = true;
    }

    public void StopShoot()
    {
        StopCoroutine(coroutineShoot);
    }


    private IEnumerator ShootAnimation()
    {
        Debug.Log("yes");
        _shoots = false;

        for (int i = 0; i < frames.Length; i++)
        {
            _mySpriteRenderer.sprite = frames[i];
            yield return new WaitForSeconds(animspeed);
        }
        _myWeapon.StartShoot();

        _shoots = true;
    }
}
