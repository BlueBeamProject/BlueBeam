using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StreetGenerator : MonoBehaviour
{
    public Sprite[] frames;
    // Start is called before the first frame update
    public void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject route = new GameObject();
            route.name = "route" + i;
            route.transform.SetParent(GetComponent<Transform>());
            route.AddComponent<Transform>();
            route.AddComponent<SpriteRenderer>();
            SpriteRenderer sprite = route.GetComponent<SpriteRenderer>();
            sprite.sprite = frames[i/frames.Length];
            route.transform.position = new Vector3(i * frames[i/frames.Length].border.x, -4, 0);
        }
    }

    public void Update()
    {
    }
}
