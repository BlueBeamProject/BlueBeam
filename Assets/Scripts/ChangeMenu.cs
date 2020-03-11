using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMenu : MonoBehaviour
{
   /* public GameObject MainMenu;
    public GameObject CampagneMenu;
    public GameObject EndlessMenu;
    public GameObject BattleRoyaleMenu;
    public GameObject OptionsMenu;
    public GameObject PlayerNumberMenu;
    public GameObject PlayerConfigureMenu;*/

   public GameObject menu;
   public GameObject previousMenu;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject.FindGameObjectWithTag("Menu").SetActive(false);
            previousMenu.SetActive(true);
        }
    }
    
    public void ChangeMenuByName()
    {
        
        GameObject.FindGameObjectWithTag("Menu").SetActive(false);

        menu.SetActive(true);
        
        


        /* switch (sceneName)
         {
             case "MainMenu":
                 MainMenu.SetActive(true);
                 CampagneMenu.SetActive(false);
                 EndlessMenu.SetActive(false);
                 BattleRoyaleMenu.SetActive(false);
                 OptionsMenu.SetActive(false);
                 PlayerNumberMenu.SetActive(false);
                 PlayerConfigureMenu.SetActive(false);
                 break;
             case "CampagneMenu":
                 MainMenu.SetActive(false);
                 CampagneMenu.SetActive(true);
                 EndlessMenu.SetActive(false);
                 BattleRoyaleMenu.SetActive(false);
                 OptionsMenu.SetActive(false);
                 PlayerNumberMenu.SetActive(false);
                 PlayerConfigureMenu.SetActive(false);
                 break;
             case "EndlessMenu":
                 MainMenu.SetActive(false);
                 CampagneMenu.SetActive(false);
                 EndlessMenu.SetActive(true);
                 BattleRoyaleMenu.SetActive(false);
                 OptionsMenu.SetActive(false);
                 PlayerNumberMenu.SetActive(false);
                 PlayerConfigureMenu.SetActive(false);
                 break;
             case "BattleRoyaleMenu":
                 MainMenu.SetActive(false);
                 CampagneMenu.SetActive(false);
                 EndlessMenu.SetActive(false);
                 BattleRoyaleMenu.SetActive(true);
                 OptionsMenu.SetActive(false);
                 PlayerNumberMenu.SetActive(false);
                 PlayerConfigureMenu.SetActive(false);
                 break;
             case "OptionsMenu":
                 MainMenu.SetActive(false);
                 CampagneMenu.SetActive(false);
                 EndlessMenu.SetActive(false);
                 BattleRoyaleMenu.SetActive(false);
                 OptionsMenu.SetActive(true);
                 PlayerNumberMenu.SetActive(false);
                 PlayerConfigureMenu.SetActive(false);
                 break;
             case "PlayerNumberMenu":
                 MainMenu.SetActive(false);
                 CampagneMenu.SetActive(false);
                 EndlessMenu.SetActive(false);
                 BattleRoyaleMenu.SetActive(false);
                 OptionsMenu.SetActive(false);
                 PlayerNumberMenu.SetActive(true);
                 PlayerConfigureMenu.SetActive(false);
                 break;
             case "PlayerConfigureMenu":
                 MainMenu.SetActive(false);
                 CampagneMenu.SetActive(false);
                 EndlessMenu.SetActive(false);
                 BattleRoyaleMenu.SetActive(false);
                 OptionsMenu.SetActive(true);
                 PlayerNumberMenu.SetActive(false);
                 PlayerConfigureMenu.SetActive(false);
                 break;
             default:
                 Debug.Log("tes con");
                 break;
             
                 
         }*/



    }
}
