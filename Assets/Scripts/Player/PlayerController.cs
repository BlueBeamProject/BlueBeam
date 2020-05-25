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
    private static int jumpBP3;
    private static int slideBP3;
    private static int attackBP3;
    private static int dashBP3;
    private static int jumpBP4;
    private static int slideBP4;
    private static int attackBP4;
    private static int dashBP4;

    void Awake()
    {

        ReloadControl();
        
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
                case 3:
                    if (Input.GetKeyDown((KeyCode)jumpBP3))
                        _myPhysics.Jump();

                    if (Input.GetKeyDown((KeyCode)slideBP3))
                        _myPhysics.Slide();

                    if (Input.GetKeyDown((KeyCode)attackBP3))
                        _myPhysics.Attack();

                    if (Input.GetKeyDown((KeyCode)dashBP3))
                        _myPhysics.Dash();
                    break;
                case 4:
                    if (Input.GetKeyDown((KeyCode)jumpBP4))
                        _myPhysics.Jump();

                    if (Input.GetKeyDown((KeyCode)slideBP4))
                        _myPhysics.Slide();

                    if (Input.GetKeyDown((KeyCode)attackBP4))
                        _myPhysics.Attack();

                    if (Input.GetKeyDown((KeyCode)dashBP4))
                        _myPhysics.Dash();
                    break;
                default:
                    Debug.Log("[PlayerController] t'as oublié le playerID ");
                    break;

            }


            /*
            if (Input.GetKeyDown(KeyCode.P))
                _myPhysics.Die();*/

           


        }
        
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
        
        jumpBP3= SaveData.ReadValueInt("JumpP3");
        slideBP3 = SaveData.ReadValueInt("SlideP3");
        attackBP3 = SaveData.ReadValueInt("AttackP3");
        dashBP3 = SaveData.ReadValueInt("DashP3");
        
        jumpBP4 = SaveData.ReadValueInt("JumpP4");
        slideBP4 = SaveData.ReadValueInt("SlideP4");
        attackBP4 = SaveData.ReadValueInt("AttackP4");
        dashBP4 = SaveData.ReadValueInt("DashP4");
    }
}
