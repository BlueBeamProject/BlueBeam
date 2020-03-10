using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerAPI : MonoBehaviour
{
    private bool HLP1 = false;
    private bool VLP1 = false;
    private bool TP1 = false;
    private bool HRP1 = false;
    private bool VRP1 = false;
    private bool HDP1 = false;
    private bool VDP1 = false;
    // Start is called before the first frame update
    public int NumberPlayer = 4;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        /*
         *Le support va jusqu'à 4 manettes
         * Pour récupérer par exemple le bouton du bas : Input.GetButtonDown("DownButtonP1")  -> sortie bool (true ou false)
         *    avec P1 le numéro du joueur (P1,P2,P3,P4)
         * Pour récupérer un Axis : Input.GetAxis("HorizontalLeftP1") -> sortie float entre -1 et 1
         *   avec P1 le numéro du joueur (P1,P2,P3,P4)
         *
         *Pour les différents noms de bouton et d'axe voir plus bas
         *
         * 
         */
        
        for (int i = 1; i <= NumberPlayer; i++)
        {
            
            //Player i
            if((Input.GetAxis("HorizontalLeftP"+i) == 1 || Input.GetAxis("HorizontalLeftP"+i) == -1) && !HLP1)
            {
                Debug.Log("[Controller API] Horizontal Left P" + i +" : " + Input.GetAxis("HorizontalLeftP"+i));
                HLP1 = true; 
            }
            else if (Input.GetAxis("HorizontalLeftP"+i) != 0 && !HLP1)
            {
                Debug.Log("[Controller API] Horizontal Left P" + i + " : " + Input.GetAxis("HorizontalLeftP"+i));
            }
            else if (Input.GetAxis("HorizontalLeftP"+i) == 0 && HLP1)
            {
                HLP1 = false;
            }
            
            if((Input.GetAxis("VerticalLeftP"+i) == 1 || Input.GetAxis("VerticalLeftP"+i) == -1) && !VLP1)
            {
                Debug.Log("[Controller API] Vertical Left P" + i +" : " + Input.GetAxis("VerticalLeftP"+i));
                VLP1 = true; 
            }
            else if (Input.GetAxis("VerticalLeftP"+i) != 0 && !VLP1)
            {
                Debug.Log("[Controller API] Vertical Left P" + i +" : " + Input.GetAxis("VerticalLeftP"+i));
            }
            else if (Input.GetAxis("VerticalLeftP"+i) == 0 && VLP1)
            {
                VLP1 = false;
            }
            
            if((Input.GetAxis("TriggerP"+i) == 1 || Input.GetAxis("TriggerP"+i) == -1) && !TP1)
            {
                Debug.Log("[Controller API] Trigger P" + i +" : " + Input.GetAxis("TriggerP"+i));
                TP1 = true; 
            }
            else if (Input.GetAxis("TriggerP"+i) != 0 && !TP1)
            {
                Debug.Log("[Controller API] Trigger P" + i +" : " + Input.GetAxis("TriggerP"+i));
            }
            else if (Input.GetAxis("TriggerP"+i) == 0 && TP1)
            {
                TP1 = false;
            }
            
            if((Input.GetAxis("HorizontalRightP"+i) == 1 || Input.GetAxis("HorizontalRightP"+i) == -1) && !HRP1)
            {
                Debug.Log("[Controller API] Horizontal Right P" + i +" : " + Input.GetAxis("HorizontalRightP"+i));
                HRP1 = true; 
            }
            else if (Input.GetAxis("HorizontalRightP"+i) != 0 && !HRP1)
            {
                Debug.Log("[Controller API] Horizontal Right P" + i +" : " + Input.GetAxis("HorizontalRightP"+i));
            }
            else if (Input.GetAxis("HorizontalRightP"+i) == 0 && HRP1)
            {
                HRP1 = false;
            }
            
            if((Input.GetAxis("VerticalRightP"+i) == 1 || Input.GetAxis("VerticalRightP"+i) == -1) && !VRP1)
            {
                Debug.Log("[Controller API] Vertical Right P" + i +" : " + Input.GetAxis("VerticalRightP"+i));
                VRP1 = true; 
            }
            else if (Input.GetAxis("VerticalRightP"+i) != 0 && !VRP1)
            {
                Debug.Log("[Controller API] Vertical Right P" + i +" : " + Input.GetAxis("VerticalRightP"+i));
            }
            else if (Input.GetAxis("VerticalRightP"+i) == 0 && VRP1)
            {
                VRP1 = false;
            }
            
            if((Input.GetAxis("HorizontalDpadP"+i) == 1 || Input.GetAxis("HorizontalDpadP"+i) == -1) && !HDP1)
            {
                Debug.Log("[Controller API] Horizontal Dpad P" + i +" : " + Input.GetAxis("HorizontalDpadP"+i));
                HDP1 = true; 
            }
            else if (Input.GetAxis("HorizontalDpadP"+i) != 0 && !HDP1)
            {
                Debug.Log("[Controller API] Horizontal Dpad P" + i +" : " + Input.GetAxis("HorizontalDpadP"+i));
                HDP1 = true;
            }
            else if (Input.GetAxis("HorizontalDpadP"+i) == 0 && HDP1)
            {
                HDP1 = false;
            }
            
            if((Input.GetAxis("VerticalDpadP"+i) == 1 || Input.GetAxis("VerticalDpadP"+i) == -1) && !VDP1)
            {
                Debug.Log("[Controller API] Vertical Dpad P" + i +" : " + Input.GetAxis("VerticalDpadP"+i));
                VDP1 = true; 
            }
            else if (Input.GetAxis("VerticalDpadP"+i) != 0 && !VDP1)
            {
                Debug.Log("[Controller API] Vertical Dpad P" + i +" : " + Input.GetAxis("VerticalDpadP"+i));
                VDP1 = true;
            }
            else if (Input.GetAxis("VerticalDpadP"+i) == 0 && VDP1)
            {
                VDP1 = false;
            }

            if (Input.GetButtonDown("DownButtonP"+i))
            {
                Debug.Log("[Controller API] Button Down P" + i);
            }
            
            if (Input.GetButtonDown("RightButtonP"+i))
            {
                Debug.Log("[Controller API] Button Right P" + i);
            }
            
            if (Input.GetButtonDown("LeftButtonP"+i))
            {
                Debug.Log("[Controller API] Button Left P" + i);
            }
            
            if (Input.GetButtonDown("UpButtonP"+i))
            {
                Debug.Log("[Controller API] Button Up P" + i);
            }
            
            if (Input.GetButtonDown("BumperLeftP"+i))
            {
                Debug.Log("[Controller API] Bumper Left P" + i);
            }
            
            if (Input.GetButtonDown("BumperRightP"+i))
            {
                Debug.Log("[Controller API] Bumper Right P" + i);
            }
            
            if (Input.GetButtonDown("BackButtonP"+i))
            {
                Debug.Log("[Controller API] Button Back P" + i);
            }
            
            if (Input.GetButtonDown("StartButtonP"+i))
            {
                Debug.Log("[Controller API] Button Start P" + i);
            }
            
            if (Input.GetButtonDown("StickClickLeftP"+i))
            {
                Debug.Log("[Controller API] Stick Click Left P" + i);
            }
            
            if (Input.GetButtonDown("StickClickRightP"+i))
            {
                Debug.Log("[Controller API] Stick Click Right P" + i);
            }
        }
    }

    public bool OnPressButton(string Button,int PlayerID)
    {
        if (Input.GetButtonDown(Button + "P" + PlayerID))
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public float OnTriggerAxis(string Axis, int PlayerID)
    {
        return Input.GetAxis(Axis + "P" + PlayerID);
    }
}
