﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject coins;
    public GameObject coinsboom;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Money.Add();
            Destroy(coins);
            Instantiate(coinsboom, transform.position, Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("Laser"))
        {
            Destroy(coins);
            Instantiate(coinsboom, transform.position, Quaternion.identity);
        }
    }
}
