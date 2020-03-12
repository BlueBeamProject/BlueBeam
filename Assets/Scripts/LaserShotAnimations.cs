using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShotAnimations : MonoBehaviour
{

    private float newPos;
    public Sprite laserSprite;
    private GameObject _ennemy;
    private Vector2 startPos;
    private Vector2 _ennemyPosition;
    private bool activated;
    private SpriteRenderer mySprite;

    void Start()
    {
        newPos = 0;
        activated = false;
        _ennemy = GameObject.FindGameObjectWithTag("Ennemy");
        _ennemyPosition = new Vector2(_ennemy.transform.position.x, _ennemy.transform.position.y);
        startPos = _ennemyPosition + new Vector2(-3.29629f, 3.755829f);
        mySprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (activated)
        {
            mySprite.sprite = laserSprite;
            newPos += 0.75f;
            transform.position = startPos + Vector2.left * newPos;
        }
        else
            mySprite.sprite = null;
    }

    public void Activate()
    {
        activated = true;
    }
}
