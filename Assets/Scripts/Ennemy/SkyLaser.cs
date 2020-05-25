using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyLaser : MonoBehaviour
{
    public GameObject death;
    // Start is called before the first frame update
    public GameObject skyLaser;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Attack") || collision.gameObject.CompareTag("Laser"))
            Die();
    }

    private void Die()
    {
        Destroy(skyLaser);
        Instantiate(death, transform.position, Quaternion.identity);
    }
}
