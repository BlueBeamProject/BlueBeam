using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShotAnimations : MonoBehaviour
{

    public float newPos;
    private float scrollSpeed = -30f;
    private Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
       
            //19.625 et 25.207
            newPos += 0.75f;
      
        

        transform.position = startPos + Vector2.left * newPos;
    }
}
