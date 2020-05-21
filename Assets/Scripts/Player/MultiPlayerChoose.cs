using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPlayerChoose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void chosePlayerInGame(int n)
    {
        Debug.Log("Player set to " + n);
        SaveData.WriteValueInt("PlayerInGame",n);
        SaveData.WriteValueInt("PlayerInGameMemorie",n);
    }
}
