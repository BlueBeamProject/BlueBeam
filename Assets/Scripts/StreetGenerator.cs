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
            routes[i].transform.SetParent(GetComponent<Transform>());
            routes[i].AddComponent<Transform>();
            routes[i].AddComponent<SpriteRenderer>();
            SpriteRenderer sprite = routes[i].GetComponent<SpriteRenderer>();
            sprite.sprite = frames[i%frames.Length];
            routes[i].transform.position = new Vector3(originalPosition.x + i*width, originalPosition.y);
        }
    }

    public void Update()
    {
    }
}
