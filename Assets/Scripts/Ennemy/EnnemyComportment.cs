using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyComportment : MonoBehaviour
{
    public GameObject death;
    public GameObject ennemy;
    private EnnemyAnimations _myAnimations;
    private Weapon _myWeapon;

    void Start()
    {
        _myAnimations = GetComponent<EnnemyAnimations>();
        _myWeapon = GetComponent<Weapon>();
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Laser"))
            Die();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        int x = 0;
        if (collider.gameObject.CompareTag("Player") && (x == 0))
        {
            x++;
            _myAnimations.Shoot();
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            _myAnimations.StopShoot();
            _myWeapon.CantShoot();
        }
    }

    public void Die()
    {
        Destroy(ennemy);
        Instantiate(death, transform.position, Quaternion.identity);
    }
}
