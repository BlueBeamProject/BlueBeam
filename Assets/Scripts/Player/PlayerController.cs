using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private PlayerPhysics _myPhysics;
    private GameObject pauseUI;
    private PauseMenu _pauseMenu;

    private static int jumpB;
    private static int slideB;
    private static int attackB;
    private static int dashB;

    void Awake()
    { 
        
        ReloadControl();
        
        Debug.Log("====Control====");
        Debug.Log("Jump : " + ((KeyCode)jumpB).ToString());
        Debug.Log("Slide : " + ((KeyCode)slideB).ToString());
        Debug.Log("Attack : " + ((KeyCode)attackB).ToString());
        Debug.Log("Dash : " + ((KeyCode)dashB).ToString());
        Debug.Log("Suicide : P");
        Debug.Log("Pause/Unpause : Escape");
        
        
        
    }
    

    
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
            if (Input.GetKeyDown((KeyCode)jumpB))
                _myPhysics.Jump();

            if (Input.GetKeyDown((KeyCode)slideB))
                _myPhysics.Slide();

            if (Input.GetKeyDown((KeyCode)attackB))
                _myPhysics.Attack();

            if (Input.GetKeyDown((KeyCode)dashB))
                _myPhysics.Dash();

            if (Input.GetKeyDown(KeyCode.P))
                _myPhysics.Die();

            if (Input.GetKeyDown(KeyCode.Escape))
                _pauseMenu.Pause();


        }
        if (Input.GetKeyDown(KeyCode.Escape))
            _pauseMenu.Resume();



    }

    public static void ReloadControl()
    {
        jumpB = SaveData.ReadValueInt("JumpP1");
        slideB = SaveData.ReadValueInt("SlideP1");
        attackB = SaveData.ReadValueInt("AttackP1");
        dashB = SaveData.ReadValueInt("DashP1");
    }
}
