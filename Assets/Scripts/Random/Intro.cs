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
    // Start is called before the first frame update
    void Start()
    {
        first = true;
        second = true;
        third = true;
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
            if (Time.timeScale > 0.1f)
                Time.timeScale -= 0.005f;
        }
        else if (second && player.transform.position.x > 60)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                StartCoroutine(ReturnTime());
                second = false;
            }
            if (Time.timeScale > 0.1f)
                Time.timeScale -= 0.005f;
        }
        else if (third && player.transform.position.x > 90)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                StartCoroutine(ReturnTime());
                third = false;
            }
            if (Time.timeScale > 0.1f)
                Time.timeScale -= 0.005f;
        }
        else if (player.transform.position.x > 120)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    IEnumerator ReturnTime()
    {
        while (Time.timeScale < 1)
        {
            Debug.Log("hihi");
            yield return new WaitForSeconds(0.005f);
            Time.timeScale += 0.01f;
        }
    }
}
