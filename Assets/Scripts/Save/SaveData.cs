using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static void AddValueInt(string name, int value)
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
    
    public static void WriteValueInt(string name, int value)
    {
        if (PlayerPrefs.HasKey(name))
        {
            PlayerPrefs.SetInt(name,value);
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
                
            return PlayerPrefs.GetInt(name);
        }
        else
        {
            Debug.Log("[ReadValueInt]" + name + " n'est pas initialisé dans le PlayerPrefs");
            return 0;
        }
    }
    
    public static void WriteValueString(string name, string value)
    {
        if (PlayerPrefs.HasKey(name))
        {
            PlayerPrefs.SetString(name, value);
        }
        else
        {
           
            Debug.Log("[WriteValueString]" + name + " n'est pas initialisé dans le PlayerPrefs");
        }
    }
    
    public static string ReadValueString(string name)
    {
        if (PlayerPrefs.HasKey(name))
        {
                
            return PlayerPrefs.GetString(name);
        }
        else
        {
            Debug.Log("[ReadValueString]" + name + " n'est pas initialisé dans le PlayerPrefs");
            return "";
        }
    }

    public static void Save()
    {
        PlayerPrefs.Save();
    }
}
