using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public DelayedStart _myMusic;
    // Start is called before the first frame update
    void Start()
    {
        _myMusic = GetComponent<DelayedStart>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
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
        Debug.Log("TEst");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        Debug.Log("Suis je en pose");
        Debug.Log("TEst");
       
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        _myMusic.PauseMusic();

    }

    public void LoadMenu()
    {
        Debug.Log("TEst");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitApplication()
    {
        Debug.Log("TEst");
        Application.Quit();
    }
}
