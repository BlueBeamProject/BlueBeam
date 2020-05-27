using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShot : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = (transform.right * speed)*(-0.5f);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    public void Die()
    {
        Destroy(gameObject);
    }

}
