using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject _startMusic;
    private DelayedStart _delayedStart;

    // Start is called before the first frame update
    void Start()
    {

        _delayedStart = _startMusic.GetComponent<DelayedStart>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        _delayedStart.PlayMusic();
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        
    }

    public void LoadMenu()
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitApplication()
    {

        Application.Quit();
    }
}
