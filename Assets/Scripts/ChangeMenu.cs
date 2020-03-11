using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMenu : MonoBehaviour
{    
    /*
    public GameObject MainMenu;
    public GameObject CampagneMenu;
    public GameObject EndlessMenu;
    public GameObject BattleRoyaleMenu;
    public GameObject OptionsMenu;
    public GameObject PlayerNumberMenu;
    public GameObject PlayerConfigureMenu;
    */

    public GameObject Menu;
 
   
  
  
  
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        
        
        
      
    }
    
    
    
    public void ChangeMenuByName(/*string menu*/)
    {
        GameObject.FindGameObjectWithTag("Menu").SetActive(false);
        Menu.SetActive(true);

        /*
        switch (menu)
        {
            case "MainMenu":
                MainMenu.SetActive(true);
                break;
            case "CampagneMenu":
                CampagneMenu.SetActive(true);
                break;
            case "EndlessMenu":
                EndlessMenu.SetActive(true);
                break;
            case "BattleRoyaleMenu":
                BattleRoyaleMenu.SetActive(true);
                break;
            case "OptionsMenu":
                OptionsMenu.SetActive(true);
                break;
            case "PlayerNumberMenu":
                PlayerNumberMenu.SetActive(true);
                break;
            case "PlayerConfigureMenu":
                PlayerConfigureMenu.SetActive(true);
                break;
            default:
                MainMenu.SetActive(true);
                Debug.Log("Default --> Main menu");
                break;
        }*/

    }
}
