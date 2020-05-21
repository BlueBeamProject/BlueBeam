using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class PlayerController : MonoBehaviour
{
    private PlayerPhysics _myPhysics;
    public GameObject pauseUI;
    private PauseMenu _pauseMenu;

    public int PlayerID;

    private static int jumpBP1;
    private static int slideBP1;
    private static int attackBP1;
    private static int dashBP1;
    private static int jumpBP2;
    private static int slideBP2;
    private static int attackBP2;
    private static int dashBP2;

    void Awake()
    {

        ReloadControl();

        /*Debug.Log("====Control====");
        Debug.Log("Jump : " + ((KeyCode)jumpB).ToString());
        Debug.Log("Slide : " + ((KeyCode)slideB).ToString());
        Debug.Log("Attack : " + ((KeyCode)attackB).ToString());
        Debug.Log("Dash : " + ((KeyCode)dashB).ToString());
        Debug.Log("Suicide : P");
        Debug.Log("Pause/Unpause : Escape");*/



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

            switch (PlayerID)
            {
                case 1:
                    if (Input.GetKeyDown((KeyCode)jumpBP1))
                        _myPhysics.Jump();

                    if (Input.GetKeyDown((KeyCode)slideBP1))
                        _myPhysics.Slide();

                    if (Input.GetKeyDown((KeyCode)attackBP1))
                        _myPhysics.Attack();

                    if (Input.GetKeyDown((KeyCode)dashBP1))
                        _myPhysics.Dash();
                    break;
                case 2:
                    if (Input.GetKeyDown((KeyCode)jumpBP2))
                        _myPhysics.Jump();

                    if (Input.GetKeyDown((KeyCode)slideBP2))
                        _myPhysics.Slide();

                    if (Input.GetKeyDown((KeyCode)attackBP2))
                        _myPhysics.Attack();

                    if (Input.GetKeyDown((KeyCode)dashBP2))
                        _myPhysics.Dash();
                    break;
                default:
                    Debug.Log("[PlayerController] t'as oublié le playerID ");
                    break;

            }



            if (Input.GetKeyDown(KeyCode.P))
                _myPhysics.Die();

           /* if (Input.GetKeyDown(KeyCode.Escape))
                _pauseMenu.Pause();*/


        }

        /*if (Input.GetKeyDown(KeyCode.Escape))
            _pauseMenu.Resume();*/



    }

    public static void ReloadControl()
    {
        jumpBP1 = SaveData.ReadValueInt("JumpP1");
        slideBP1 = SaveData.ReadValueInt("SlideP1");
        attackBP1 = SaveData.ReadValueInt("AttackP1");
        dashBP1 = SaveData.ReadValueInt("DashP1");

        jumpBP2 = SaveData.ReadValueInt("JumpP2");
        slideBP2 = SaveData.ReadValueInt("SlideP2");
        attackBP2 = SaveData.ReadValueInt("AttackP2");
        dashBP2 = SaveData.ReadValueInt("DashP2");
    }
}
