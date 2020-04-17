using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldAnimation : MonoBehaviour
{
    public Sprite[] frames;
    public GameObject shield;
    private SpriteRenderer _mySpriteRenderer;
    private static bool stp;
    public GameObject player;
    public float animspeed;
    public static bool useless;

    void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (useless)
        {
            shield.SetActive(false);

        }

        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z-0.01f);
        if (stp)
        {
            shield.SetActive(true);
            StartCoroutine(shildAnimation());
        }
    }

    public static void ShildAn()
    {
        stp = true;
    }

    public static void StopShildAn()
    {
        useless = true;
    }

    IEnumerator shildAnimation()
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
