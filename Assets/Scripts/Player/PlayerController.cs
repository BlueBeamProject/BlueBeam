using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private PlayerPhysics _myPhysics;
    public GameObject pauseUI;
    private PauseMenu _pauseMenu;

    private string jumpB;
    private string slideB;
    private string attackB;
    private string dashB;

    void Awake()
    { 
        jumpB = SaveData.ReadValueString("JumpP1");
        slideB = SaveData.ReadValueString("SlideP1");
        attackB = SaveData.ReadValueString("AttackP1");
        dashB = SaveData.ReadValueString("DashP1");
    }
    

    
    // Start is called before the first frame update
    void Start()
    {
        _myPhysics = GetComponent<PlayerPhysics>();
        _pauseMenu = pauseUI.GetComponent<PauseMenu>();
        Debug.Log("JumpB : " + jumpB);
        Debug.Log("JumpP1 : " + SaveData.ReadValueString("JumpP1"));

    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.gameIsPaused)
        {
            if (Input.GetKeyDown(jumpB))
                _myPhysics.Jump();

            if (Input.GetKeyDown(slideB))
                _myPhysics.Slide();

            if (Input.GetKeyDown(attackB))
                _myPhysics.Attack();

            if (Input.GetKeyDown(dashB))
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
