using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShotAnimations : MonoBehaviour
{

    public float newPos;
    private GameObject _ennemy = GameObject.FindGameObjectWithTag("Ennemy");
    private Vector2 startPos;
    private Vector2 _ennemyPosition; 

    void Start()
    {
        _ennemyPosition = new Vector2(_ennemy.transform.position.x, _ennemy.transform.position.y);
        startPos = _ennemyPosition + new Vector2(-3.29629f, 3.755829f);
    }

    void Update()
    {
        newPos += 0.75f;
        transform.position = startPos + Vector2.left * newPos;
    }
}
