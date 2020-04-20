using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldAnimation : MonoBehaviour
{
    public Sprite[] frames;
    public GameObject shield;
    private SpriteRenderer _mySpriteRenderer;
    private static bool stp;
    public float animspeed;
    public static bool useless;

    void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (useless)
            shield.SetActive(false);

        if (stp)
        {
            shield.SetActive(true);
            StartCoroutine(ShieldAnim());
        }
    }

    public void ShieldAn()
    {
        stp = true;
    }

    public void StopShieldAn()
    {
        useless = true;
    }

    IEnumerator ShieldAnim()
    {
        stp = false;
        _mySpriteRenderer.sprite = frames[0];
        yield return new WaitForSeconds(animspeed);
        _mySpriteRenderer.sprite = frames[1];
        yield return new WaitForSeconds(animspeed);
        _mySpriteRenderer.sprite = frames[2];
        yield return new WaitForSeconds(animspeed);
        _mySpriteRenderer.sprite = frames[3];
        yield return new WaitForSeconds(animspeed);
        _mySpriteRenderer.sprite = frames[4];
        yield return new WaitForSeconds(animspeed);
        _mySpriteRenderer.sprite = frames[5];
        yield return new WaitForSeconds(animspeed);
        _mySpriteRenderer.sprite = frames[6];
        yield return new WaitForSeconds(animspeed);
        stp = true;
    }
}
