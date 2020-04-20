using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //pour initiaiser une valeur ->
        //PlayerPrefs.SetInt("name", score);
        //dans le void start
        //puis exécuter le projet dans unity puis enlevé la ligne
        if (!PlayerPrefs.HasKey("Money"))
        {
            PlayerPrefs.SetInt("Money", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void WriteValueInt(string name, int value)
    {
        if (PlayerPrefs.HasKey(name))
        {
            PlayerPrefs.SetInt(name, PlayerPrefs.GetInt(name) + value);
            Debug.Log("[WriteValueInt]" +name + " sauvergardé dans le PlayerPrefs \n Valeur : " + PlayerPrefs.GetInt(name));
        }
        else
        {
           
            Debug.Log("[WriteValueInt]" + name + " n'est pas initialisé dans le PlayerPrefs");
        }
    }
    
    public static int ReadValueInt(string name)
    {
        if (PlayerPrefs.HasKey(name))
        {
                
            Debug.Log("[ReadValueInt]" +name + " : " + PlayerPrefs.GetInt(name));
            return PlayerPrefs.GetInt(name);
        }
        else
        {
           
            Debug.Log("[ReadValueInt]" + name + " n'existe pas dans le PlayerPrefs");
            return 0;
        }
    }
}
