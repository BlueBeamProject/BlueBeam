using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class MultiDisplayPlayer : MonoBehaviour
{


    public GameObject p1, p2 /*,p3,p4*/ ;
    
    // Start is called before the first frame update
    void Start()
    {
        int nbr_player = SaveData.ReadValueInt("PlayerInGameMemorie");

        switch (nbr_player)
        {
            case 1:
                p1.SetActive(true);
                break;
            case 2:
                p1.SetActive(true);
                p2.SetActive(true);
                break;
            case 3:
                p1.SetActive(true);
                p2.SetActive(true);
                //p3.setActive(true);
                break;
            case 4:   
                p1.SetActive(true);
                p2.SetActive(true);
                //p3.setActive(true);
                //p4.setActive(true);
                break;
            default:
                Debug.Log("[MultiDisplayPlayer] Erreur sur le nombre de joueur(s) : " + SaveData.ReadValueInt("PlayerInMemorie"));
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
