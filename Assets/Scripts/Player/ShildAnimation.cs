using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShildAnimation : MonoBehaviour
{
    public Sprite[] frames;
    private SpriteRenderer _mySpriteRenderer;
    public float moveSpeed;
    private Vector3 _movement;
    private Transform _transform;

    void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
        _movement = new Vector3(moveSpeed, 0, 0);
        _transform = GetComponent<Transform>();
    }

    void Update()
    {
        _transform.position += _movement * Time.deltaTime * moveSpeed;
    }

    public void ShildAn()
    {
        StartCoroutine("shildAnimation");
    }

    IEnumerator shildAnimation()
    {
        print("yes");
        _mySpriteRenderer.sprite = frames[4];
        yield return new WaitForSeconds(1);
        _mySpriteRenderer.sprite = frames[3];
        yield return new WaitForSeconds(1);
        _mySpriteRenderer.sprite = frames[2];
        yield return new WaitForSeconds(1);
        _mySpriteRenderer.sprite = frames[1];
        yield return new WaitForSeconds(1);
        _mySpriteRenderer.sprite = frames[0];
    }
}
