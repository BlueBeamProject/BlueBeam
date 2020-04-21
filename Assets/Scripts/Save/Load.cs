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
            PlayerPrefs.SetString("JumpP1", "space");
            Debug.Log("set");
        }
        else
        {
            Debug.Log("Déjà la : " + SaveData.ReadValueString("JumpP1"));
        }
        
        if (!PlayerPrefs.HasKey("SlideP1"))
        {
            PlayerPrefs.SetString("SlideP1", "s");
        }
        
        if (!PlayerPrefs.HasKey("AttackP1"))
        {
            PlayerPrefs.SetString("AttackP1", "d");
        }
        
        if (!PlayerPrefs.HasKey("DashP1"))
        {
            PlayerPrefs.SetString("DashP1", "f");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
