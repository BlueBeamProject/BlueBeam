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
        
    }

    public void ShopActive(bool statut)
    {
        MoneyShow.IsShopActive = statut;
    }
}
