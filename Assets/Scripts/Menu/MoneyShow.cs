using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyShow : MonoBehaviour
{
    // Start is called before the first frame update
    private static GameObject UI;
    public static bool IsShopActive;
    void Start()
    {
        refreshMoney();
        IsShopActive = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void refreshMoney()
    {
        UI = GameObject.FindGameObjectWithTag("CoinsUI");
        int coinUI = SaveData.ReadValueInt("Money");
        UI.GetComponent<Text>().text = "" + coinUI;

        if (IsShopActive)
        {
            Debug.Log("Shop Refresh");
            Shop.RefreshShop();
        }
        
    }
}
