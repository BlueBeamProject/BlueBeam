using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyComportment : MonoBehaviour
{
    public Transform target;
    public float range = 15f;
    public BoxCollider2D[] colliders;
    public GameObject death;
    public GameObject Ennemy;

    private EnnemyAnimations _myAnimations;
    private float _distanceToTarget;
    private GameObject _target;
    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player");
        _myAnimations = GetComponent<EnnemyAnimations>();
    }

    
    void Update()
    {
        _distanceToTarget = transform.position.x - _target.transform.position.x;
        
        if (_distanceToTarget < range)
            _myAnimations.Shoot();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Attack"))
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(Ennemy);
        Instantiate(death, transform.position, Quaternion.identity);
    }
}
