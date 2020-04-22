using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Pour initialiser un nouvelle donné sauvergardé recopier les lignes en dessous
        //et mettez une valeur par défaut si la "key" n'existe
        
        //Monney Load
        if (!PlayerPrefs.HasKey("Money"))
        {
            PlayerPrefs.SetInt("Money", 0);
        }
        
        //Inventaire Item
        if (!PlayerPrefs.HasKey("Shield"))
        {
            PlayerPrefs.SetInt("Shield", 0);
        }
        
        //Controlle default
        if (!PlayerPrefs.HasKey("JumpP1"))
        {
            PlayerPrefs.SetInt("JumpP1", 32);//space
        }

        if (!PlayerPrefs.HasKey("SlideP1"))
        {
            PlayerPrefs.SetInt("SlideP1", 115);//s
        }
        
        if (!PlayerPrefs.HasKey("AttackP1"))
        {
            PlayerPrefs.SetInt("AttackP1", 100);//d
        }
        
        if (!PlayerPrefs.HasKey("DashP1"))
        {
            PlayerPrefs.SetInt("DashP1", 102);//f
        }
        
        if (!PlayerPrefs.HasKey("JumpP2"))
        {
            PlayerPrefs.SetInt("JumpP2", 13);//return
        }

        if (!PlayerPrefs.HasKey("SlideP2"))
        {
            PlayerPrefs.SetInt("SlideP2", 108);//l
        }
        
        if (!PlayerPrefs.HasKey("AttackP2"))
        {
            PlayerPrefs.SetInt("AttackP2", 105);//i
        }
        
        if (!PlayerPrefs.HasKey("DashP2"))
        {
            PlayerPrefs.SetInt("DashP2", 276);//leftarrow
        }
        
        PlayerController.ReloadControl();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DefaultControlle()
    {
        PlayerPrefs.SetInt("JumpP1", 32);
        PlayerPrefs.SetInt("SlideP1", 115);
        PlayerPrefs.SetInt("AttackP1", 100);
        PlayerPrefs.SetInt("DashP1", 102);
        
    }
}
