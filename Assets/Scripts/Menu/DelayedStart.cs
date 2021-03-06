﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedStart : MonoBehaviour
{
    public GameObject countDown;
    public AudioSource someSound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartDelay");
        someSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.gameIsPaused)
        {
            someSound.Pause();
        }
    }

    IEnumerator StartDelay()
    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 3f;
        while (!Input.anyKey)
            yield return 0;
        countDown.gameObject.SetActive(false);
        someSound.Play();
        Time.timeScale = 1f;
    }


    public void PlayMusic()
    {
        someSound.Play();
    }
}
