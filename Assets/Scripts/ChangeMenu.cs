using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CampagneMenu;
    public GameObject EndlessMenu;
    public GameObject BattleRoyaleMenu;
    public GameObject OptionsMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ChangeMenuByName(string sceneName)
    {
        switch (sceneName)
        {
            case "MainMenu":
                MainMenu.SetActive(true);
                CampagneMenu.SetActive(false);
                EndlessMenu.SetActive(false);
                BattleRoyaleMenu.SetActive(false);
                OptionsMenu.SetActive(false);
                break;
            case "CampagneMenu":
                MainMenu.SetActive(false);
                CampagneMenu.SetActive(true);
                EndlessMenu.SetActive(false);
                BattleRoyaleMenu.SetActive(false);
                OptionsMenu.SetActive(false);
                break;
            case "EndlessMenu":
                MainMenu.SetActive(false);
                CampagneMenu.SetActive(false);
                EndlessMenu.SetActive(true);
                BattleRoyaleMenu.SetActive(false);
                OptionsMenu.SetActive(false);
                break;
            case "BattleRoyaleMenu":
                MainMenu.SetActive(false);
                CampagneMenu.SetActive(false);
                EndlessMenu.SetActive(false);
                BattleRoyaleMenu.SetActive(true);
                OptionsMenu.SetActive(false);
                break;
            case "OptionsMenu":
                MainMenu.SetActive(false);
                CampagneMenu.SetActive(false);
                EndlessMenu.SetActive(false);
                BattleRoyaleMenu.SetActive(false);
                OptionsMenu.SetActive(true);
                break;
            default:
                Debug.Log("tes con");
                break;
            
                
        }
    }
}
