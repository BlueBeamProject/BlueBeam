using System.Collections;
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

    void OnTriggerEnter2D(Collider2D collider)
    {

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
