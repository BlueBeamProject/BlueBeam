using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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

       

        StartCoroutine(ConfigurePlayerV2());
        
        
       /* while (i <= PlayerNumber && !echap && !finish)
        {
            Debug.Log("Player " + i + " : Please press Jump on your Keyboard or Controller (space or right button)");
            if (ControllerAPI.GetButton("RightButton",i))
            {
                Debug.Log("Detected Controller Player " + i );
                i++;
            }
            
        }*/
    }


    IEnumerator ConfigurePlayerV2()
    {
        Debug.Log("Player : Please press Jump on your Keyboard or Controller (space or right button) V2");
        bool done = false;

        while (!done)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                done = true;
                Debug.Log("nice");
            }

            yield return null;
        }
    }
    

    public void ConfigurePlayer(int PlayerNumber, int index)
    {

        Debug.Log("Player "+index+" : Please press Jump on your Keyboard or Controller (space or right button)");

        if (ControllerAPI.GetButton("RightButton",1))
        {
            Debug.Log("Detected Controller Player "  + index);

            if (index != PlayerNumber)
            {
                ConfigurePlayer(PlayerNumber, index + 1);
            }
        }
        else if(ControllerAPI.GetButton("RightButton",2))
        {
            Debug.Log("Detected Controller Player "  + index);
            
            if (index != PlayerNumber)
            {
                ConfigurePlayer(PlayerNumber, index + 1);
            }
        }
        else if (ControllerAPI.GetButton("RightButton", 3))
        {
            Debug.Log("Detected Controller Player "  + index);
            
            if (index != PlayerNumber)
            {
                ConfigurePlayer(PlayerNumber, index + 1);
            }
        }
        else if (ControllerAPI.GetButton("RightButton",4))
        {
            Debug.Log("Detected Controller Player "  + index);
            
            if (index != PlayerNumber)
            {
                ConfigurePlayer(PlayerNumber, index + 1);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Detected Keyboard Player "  + index);
            
            if (index != PlayerNumber)
            {
                ConfigurePlayer(PlayerNumber, index + 1);
            }
        }
    }
    
    
    
}
