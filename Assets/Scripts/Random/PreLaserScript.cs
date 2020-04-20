using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreLaserScript : MonoBehaviour
{
    private LaserScript laser;
    public bool _grounded;
    public GameObject Laser;
    public GameObject Camera;
    static bool death;

    // Start is called before the first frame update
    void Start()
    {
        death = false;
        laser = GetComponent<LaserScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _grounded = true;
            Laser.transform.position += new Vector3(0, 2, 0);
            double x = Camera.transform.position.x - 1.8;
            if (!death)
                Laser.transform.position = new Vector3((float)x, Laser.transform.position.y, Laser.transform.position.z);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _grounded = false;
        }
    }
    public static void Death()
    {
        death = true;
    }
}
