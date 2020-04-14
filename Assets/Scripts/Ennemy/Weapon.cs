using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject laserShotPrefab;
    private int fois = 0;

    

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        if (time>1.5*(fois + 1))
        {
            Shoot();
            fois++;
        }
        
       
    }
    void Shoot()
    {
        Instantiate(laserShotPrefab, firePoint.position, firePoint.rotation);

    }
}
