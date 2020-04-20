using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject laserShotPrefab;
    private bool canShoot;
    private EnnemyAnimations _myAnimations;
    private Sprite[] frames;


    void Start()
    {
        canShoot = false;
        _myAnimations = GetComponent<EnnemyAnimations>();
    }
    // Update is called once per frame
    void Update()
    {
        if (canShoot)
            StartShoot();
    }

    public void CanShoot()
    {
        canShoot = true;
    }

    public void CantShoot()
    {
        canShoot = false;
    }
    public void StartShoot()
    {
        Instantiate(laserShotPrefab, firePoint.position, firePoint.rotation);
    }
}
