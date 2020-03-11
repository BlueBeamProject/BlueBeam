using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public float newPos;
    private float scrollSpeed = -30f;
    public GameObject logo;

    private Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 19.865 && Time.time < 23.207)
        {
            //19.625 et 25.207
            newPos += 0.4f;
            if (Time.time > 20.0)
            {
                logo.SetActive(true);
            }
        }
        
        transform.position = startPos + Vector2.left * newPos;
        
        
    }
}