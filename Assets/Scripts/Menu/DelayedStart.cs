using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedStart : MonoBehaviour
{
    public GameObject countDown;
<<<<<<< Updated upstream
=======
    public AudioSource someSound;
   
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartDelay");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator StartDelay()
    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 3f;
        while (!Input.anyKey)
            yield return 0;
        countDown.gameObject.SetActive(false);
<<<<<<< Updated upstream
        Time.timeScale = 1;
=======
        someSound.Play();
        Time.timeScale = 1f;

>>>>>>> Stashed changes
    }

    public void PauseMusic()
    {
        Debug.Log("bb,");
        someSound.Pause();
    }
}
