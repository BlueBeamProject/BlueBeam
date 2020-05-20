using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public Sprite[] sprites;
    public GameObject death;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer _mySpriteRenderer = GetComponent<SpriteRenderer>();
        _mySpriteRenderer.sprite = sprites[Random.Range(0, sprites.Length - 1)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Laser"))
            Die();
    }

    private void Die()
    {
        Destroy(this);
        Instantiate(death, transform.position, Quaternion.identity);
    }
}
