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

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Attack") || collider.gameObject.CompareTag("Laser"))
            Die();
    }

    

    

    private void Die()
    {
        Destroy(skyLaser);
        Instantiate(death, transform.position, Quaternion.identity);
    }
}
