using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StreetGenerator : MonoBehaviour
{
    public Sprite[] frames;

    public float width;

    public int length;

    private GameObject[] routes;

    public Vector3 originalPosition;
    // Start is called before the first frame update
    public void Start()
    {
        routes = new GameObject[length];
        for (int i = 0; i < length; i++)
        {
            routes[i] = new GameObject();
            routes[i].name = "routes" + i;
            routes[i].AddComponent<SpriteRenderer>();
            SpriteRenderer sprite = routes[i].GetComponent<SpriteRenderer>();
            if (i % 4 == 0)
                sprite.sprite = frames[0];
            else if (i % 3 == 0)
                sprite.sprite = frames[2];
            else
                sprite.sprite = frames[1];
            
            routes[i].transform.position = new Vector3(originalPosition.x + i*width, originalPosition.y);
        }
    }

    public void Update()
    {
    }
}
