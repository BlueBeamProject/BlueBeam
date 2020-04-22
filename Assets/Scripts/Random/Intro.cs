using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public GameObject player;

    private bool first;
    private bool second;
    private bool third;
    private bool first1;
    private bool second2;
    private bool third3;
    // Start is called before the first frame update
    void Start()
    {
        first = true;
        second = true;
        third = true;
        first1 = true;
        second2 = true;
        third3 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (first && player.transform.position.x > 30)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine(ReturnTime());
                first = false;
            }
            if (first1)
            {
                first1 = false;
                StartCoroutine(SlowTime());
            }
        }
        else if (second && player.transform.position.x > 58)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                StartCoroutine(ReturnTime());
                second = false;
            }
            if (second2)
            {
                second2 = false;
                StartCoroutine(SlowTime());
            }
        }
        else if (third && player.transform.position.x > 88)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                StartCoroutine(ReturnTime());
                third = false;
            }
            if (third3)
            {
                third3 = false;
                StartCoroutine(SlowTime());
            }
        }
        else if (player.transform.position.x > 120)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    IEnumerator SlowTime()
    {
        for (int i = 0; i < 90; i++)
        {
            yield return new WaitForSeconds(0.005f);
            Time.timeScale -= 0.01f;
        }
    }

    IEnumerator ReturnTime()
    {
        while (Time.timeScale < 1)
        {
            yield return new WaitForSeconds(0.005f);
            Time.timeScale += 0.01f;
        }
    }
}
