using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    private static GameObject PriceShield;
    // Start is called before the first frame update
    void Start()
    {
        RefreshShop();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int ShieldCost = 15;

    public void BuyItem(string name)
    {
        switch (name)
        {
            case "Shield":
                if (SaveData.ReadValueInt("Money") >= ShieldCost)
                {
                    SaveData.AddValueInt("Money", -ShieldCost);
                    SaveData.AddValueInt("Shield", 1);
                    Inventaire.ShieldInv();
                }
                else
                {
                    Debug.Log("[BuyItem] Tu n'as pas assez d'argent");
                }
                break;
            default:
                Debug.Log("[BuyItem] L'item demandé n'est pas enregistré");
                break;
                
        }
        
        MoneyShow.refreshMoney();
        RefreshShop();
    }

    public static void RefreshShop()
    {
        PriceShield = GameObject.FindWithTag("ShieldCost");
        PriceShield.GetComponent<Text>().text = "" + ShieldCost;
        Inventaire.Refresh();
        
        if (SaveData.ReadValueInt("Money") < ShieldCost)
        {
            PriceShield.GetComponent<Text>().color = Color.red;
        }
        else
        {
            PriceShield.GetComponent<Text>().color = Color.white;
        }
    }
}
