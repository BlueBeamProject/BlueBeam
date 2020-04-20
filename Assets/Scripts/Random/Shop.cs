using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int ShieldCost = 15;

    public void BuyItem(string name)
    {
        switch (name)
        {
            case "Shield":
                if (SaveData.ReadValueInt("Money") >= ShieldCost)
                {
                    SaveData.WriteValueInt("Money", -ShieldCost);
                    SaveData.WriteValueInt("Shield", 1);
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
    }
}
