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
            PlayerPrefs.SetInt("JumpP1", 32);
        }

        if (!PlayerPrefs.HasKey("SlideP1"))
        {
            PlayerPrefs.SetInt("SlideP1", 115);
        }
        
        if (!PlayerPrefs.HasKey("AttackP1"))
        {
            PlayerPrefs.SetInt("AttackP1", 100);
        }
        
        if (!PlayerPrefs.HasKey("DashP1"))
        {
            PlayerPrefs.SetInt("DashP1", 102);
        }
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
