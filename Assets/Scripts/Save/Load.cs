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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
