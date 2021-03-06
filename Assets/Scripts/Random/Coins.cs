﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject coins;
    public GameObject coinsboom;

    Rigidbody2D rigidbodyy;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -15.7)
            transform.position += new Vector3(0, 30, 0);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Ground"))
            rigidbodyy.constraints = RigidbodyConstraints2D.FreezePositionY;

        if (collider.gameObject.CompareTag("Player"))
        {
            Money.Add();
            SaveData.AddValueInt("Money",1);
            SaveData.AddValueInt("CoinsPick",1);
            Destroy(coins);
            Instantiate(coinsboom, transform.position, Quaternion.identity);
        }

        if (collider.gameObject.CompareTag("Laser"))
        {
            Destroy(coins);
            Instantiate(coinsboom, transform.position, Quaternion.identity);
        }
    }
}
