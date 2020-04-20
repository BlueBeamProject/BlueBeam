using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventaire : MonoBehaviour
{
    private static GameObject ShieldInvShow;
    // Start is called before the first frame update
    void Start()
    {
        ShieldInv();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public static void ShieldInv()
    {
        ShieldInvShow = GameObject.FindWithTag("ShieldInv");
        int nbShield = SaveData.ReadValueInt("Shield");
        ShieldInvShow.GetComponent<Text>().text = "" + nbShield;
    }
}
