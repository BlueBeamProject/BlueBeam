using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //can be negative int for remove money
    public void AddMoney(int count)
    {
        SaveData.WriteValueInt("Money",count);
        MoneyShow.refreshMoney();
    }
    
    public void ResetMoney()
    {
        SaveData.WriteValueInt("Money", - SaveData.ReadValueInt("Money"));
        MoneyShow.refreshMoney();
    }
}
