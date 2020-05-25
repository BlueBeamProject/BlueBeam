using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject _startMusic;
    public AudioSource _startMusic1;
    private DelayedStart _delayedStart;
    private DelayedStart _delayedStart1;

    // Start is called before the first frame update
    void Start()
    {
        _delayedStart = _startMusic.GetComponent<DelayedStart>();
        _delayedStart1 = _startMusic1.GetComponent<DelayedStart>();
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

    

    public void Resume1()
    {
        if (gameIsPaused)
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            gameIsPaused = false;
            _delayedStart1.PlayMusic();
        }
        else
        {
            Pause();
        }

    }
    public void Resume()
    {
        if (gameIsPaused)
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            gameIsPaused = false;
            _delayedStart.PlayMusic();
        }
        else
        {
            Pause();
        }

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
