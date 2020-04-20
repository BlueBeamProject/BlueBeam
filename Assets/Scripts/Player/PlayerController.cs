using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private PlayerPhysics _myPhysics;
    public GameObject pauseUI;
    private PauseMenu _pauseMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        _myPhysics = GetComponent<PlayerPhysics>();
        _pauseMenu = pauseUI.GetComponent<PauseMenu>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.gameIsPaused)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _myPhysics.Jump();

            if (Input.GetKeyDown(KeyCode.S))
                _myPhysics.Slide();

            if (Input.GetKeyDown(KeyCode.D))
                _myPhysics.Attack();

            if (Input.GetKeyDown(KeyCode.F))
                _myPhysics.Dash();

            if (Input.GetKeyDown(KeyCode.P))
                _myPhysics.Die();

            if (Input.GetKeyDown(KeyCode.Escape))
                _pauseMenu.Pause();

            
        }
        if (Input.GetKeyDown(KeyCode.Escape))
            _pauseMenu.Resume();



    }
}
