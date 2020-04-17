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
    private static bool stp;

    void Start()
    {
        /*_mySpriteRenderer = GetComponent<SpriteRenderer>();
        _movement = new Vector3(moveSpeed, 0, 0);
        _transform = GetComponent<Transform>();*/
    }

    void Update()
    {
        /*_transform.position += _movement * Time.deltaTime * moveSpeed;*/
        if (stp)
        {
            Debug.Log("stp");
            shield.SetActive(true);
            StartCoroutine(shildAnimation());
        }
    }

    public static void ShildAn()
    {
        Debug.Log("ShildAn");
        stp = true;
    }

    public static void StopShildAn()
    {
        stp = false;
    }

    IEnumerator shildAnimation()
    {
        _mySpriteRenderer.sprite = frames[0];
        yield return new WaitForSeconds(0.2f);
        _mySpriteRenderer.sprite = frames[1];
        yield return new WaitForSeconds(0.2f);
        _mySpriteRenderer.sprite = frames[2];
        yield return new WaitForSeconds(0.2f);
        _mySpriteRenderer.sprite = frames[3];
        yield return new WaitForSeconds(0.2f);
        _mySpriteRenderer.sprite = frames[4];
        yield return new WaitForSeconds(0.2f);
        _mySpriteRenderer.sprite = frames[5];
        yield return new WaitForSeconds(0.2f);
        _mySpriteRenderer.sprite = frames[6];
        yield return new WaitForSeconds(0.2f);
    }
}
