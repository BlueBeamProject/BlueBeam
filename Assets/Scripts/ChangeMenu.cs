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
            Debug.Log("echap");
            GameObject.FindGameObjectWithTag("Menu").SetActive(false);
            previousMenu.SetActive(true);
        }
    }
    
    public void ChangeMenuByName()
    {
        
        GameObject.FindGameObjectWithTag("Menu").SetActive(false);

        menu.SetActive(true);
        
        


        

    }
}
