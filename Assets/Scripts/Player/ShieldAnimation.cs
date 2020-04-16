using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldAnimation : MonoBehaviour
{
    public Sprite[] frames;
    public GameObject shield;
    private SpriteRenderer _mySpriteRenderer;
    public float moveSpeed;
    private Vector3 _movement;
    private Transform _transform;
    private static bool stp = false;

    void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
        _movement = new Vector3(moveSpeed, 0, 0);
        _transform = GetComponent<Transform>();
        shield.SetActive(false);
    }

    void Update()
    {
        _transform.position += _movement * Time.deltaTime * moveSpeed;
        if (stp)
        {
            StartCoroutine("shildAnimation");
        }
    }

    public static void ShildAn()
    {
        stp = true;
    }

    IEnumerator shildAnimation()
    {
        stp = false;
        print("yes");
        shield.SetActive(true);
        _mySpriteRenderer.sprite = frames[4];
        yield return new WaitForSeconds(1);
        _mySpriteRenderer.sprite = frames[3];
        yield return new WaitForSeconds(0.5f);
        shield.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        _mySpriteRenderer.sprite = frames[2];
        yield return new WaitForSeconds(1);
        _mySpriteRenderer.sprite = frames[1];
        yield return new WaitForSeconds(1);
        _mySpriteRenderer.sprite = frames[0];
    }
}
