using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigureManettePlayer : MonoBehaviour
{
    // Start is called before the first frame update
   

    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;

    private static int P1controllerKey;
    private static int P2controllerKey;
    private static int P3controllerKey;
    private static int P4controllerKey;
    
    private bool configure = false;
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void HowMuchPlayerNumber(int PlayerNumber)
    {
        Debug.Log(PlayerNumber);

        bool echap = false;
        bool finish = false;
        int i = 1;
    
        /*
        while (i <= PlayerNumber && !echap && !finish)
        {
            Debug.Log("Player " + i + " : Please press Jump on your Keyboard or Controller (space or right button)");
            
        }
        */

    }
}
