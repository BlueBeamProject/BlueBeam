using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoIntro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            SceneManager.LoadScene("Menu");
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(25);
        SceneManager.LoadScene("Menu");
    }
}
