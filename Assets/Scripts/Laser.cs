using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public float newPos;
    private float scrollSpeed = -30f;
    public GameObject logo;
    public bool LogoShow = false;

    private Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 19.365 && Time.time < 23.207)
        {
            //19.625 et 25.207
            newPos += 0.75f;
            if (Time.time > 21.0 && !LogoShow)
            {
                logo.SetActive(true);
            }
        }
        
        transform.position = startPos + Vector2.left * newPos;
        
        
    }
}