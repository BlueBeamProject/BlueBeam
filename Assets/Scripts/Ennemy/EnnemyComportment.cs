using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyComportment : MonoBehaviour
{
    public GameObject death;
    public GameObject Ennemy;
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

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Attack") || collision.gameObject.CompareTag("Laser"))
        {
            Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            _myAnimations.Shoot();
            
        }
       
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            _myAnimations.StopShoot();
            _myWeapon.CantShoot();
        }

    }

    public void Die()
    {
        Destroy(Ennemy);
        Instantiate(death, transform.position, Quaternion.identity);
    }

    
}
