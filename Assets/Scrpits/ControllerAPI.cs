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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Player1
        if((Input.GetAxis("HorizontalLeftP1") == 1 || Input.GetAxis("HorizontalLeftP1") == -1) && !HLP1)
        {
            Debug.Log("[Controller API] Horizontal Left P1 : " + Input.GetAxis("HorizontalLeftP1"));
            Debug.Log("coucou");
            HLP1 = true; 
        }
        else if (Input.GetAxis("HorizontalLeftP1") != 0 && !HLP1)
        {
            Debug.Log("[Controller API] Horizontal Left P1 : " + Input.GetAxis("HorizontalLeftP1"));
        }
        else if (Input.GetAxis("HorizontalLeftP1") == 0 && HLP1)
        {
            HLP1 = false;
        }
        
        if(Input.GetAxis("VerticalLeftP1") == 1 || Input.GetAxis("VerticalLeftP1") == -1 && !VLP1)
        {
            Debug.Log("[Controller API] Vertical Left P1 : " + Input.GetAxis("VerticalLeftP1"));
            VLP1 = true; 
        }
        else if (Input.GetAxis("VerticalLeftP1") != 0 && !VLP1)
        {
            Debug.Log("[Controller API] Vertical Left P1 : " + Input.GetAxis("VerticalLeftP1"));
        }
        else if (Input.GetAxis("VerticalLeftP1") == 0 && VLP1)
        {
            VLP1 = false;
        }
        
        if(Input.GetAxis("TriggerP1") == 1 || Input.GetAxis("TriggerP1") == -1 && !TP1)
        {
            Debug.Log("[Controller API] Trigger P1 : " + Input.GetAxis("TriggerP1"));
            TP1 = true; 
        }
        else if (Input.GetAxis("TriggerP1") != 0 && !TP1)
        {
            Debug.Log("[Controller API] Trigger P1 : " + Input.GetAxis("TriggerP1"));
        }
        else if (Input.GetAxis("TriggerP1") == 0 && TP1)
        {
            TP1 = false;
        }
        
        if(Input.GetAxis("HorizontalRightP1") == 1 || Input.GetAxis("HorizontalRightP1") == -1 && !HRP1)
        {
            Debug.Log("[Controller API] Horizontal Right P1 : " + Input.GetAxis("HorizontalRightP1"));
            HRP1 = true; 
        }
        else if (Input.GetAxis("HorizontalRightP1") != 0 && !HRP1)
        {
            Debug.Log("[Controller API] Horizontal Right P1 : " + Input.GetAxis("HorizontalRightP1"));
        }
        else if (Input.GetAxis("HorizontalRightP1") == 0 && HRP1)
        {
            HRP1 = false;
        }
        
        if(Input.GetAxis("VerticalRightP1") == 1 || Input.GetAxis("VerticalRightP1") == -1 && !VRP1)
        {
            Debug.Log("[Controller API] Vertical Right P1 : " + Input.GetAxis("VerticalRightP1"));
            VRP1 = true; 
        }
        else if (Input.GetAxis("VerticalRightP1") != 0 && !VRP1)
        {
            Debug.Log("[Controller API] Vertical Right P1 : " + Input.GetAxis("VerticalRightP1"));
        }
        else if (Input.GetAxis("VerticalRightP1") == 0 && VRP1)
        {
            VRP1 = false;
        }
        
        if(Input.GetAxis("HorizontalDpadP1") == 1 || Input.GetAxis("HorizontalDpadP1") == -1 && !HDP1)
        {
            Debug.Log("[Controller API] Horizontal Dpad P1 : " + Input.GetAxis("HorizontalDpadP1"));
            HDP1 = true; 
        }
        else if (Input.GetAxis("HorizontalDpadP1") != 0 && !HDP1)
        {
            Debug.Log("[Controller API] Horizontal Dpad P1 : " + Input.GetAxis("HorizontalDpadP1"));
            HDP1 = true;
        }
        else if (Input.GetAxis("HorizontalDpadP1") == 0 && HDP1)
        {
            HDP1 = false;
        }
        
        if(Input.GetAxis("VerticalDpadP1") == 1 || Input.GetAxis("VerticalDpadP1") == -1 && !VDP1)
        {
            Debug.Log("[Controller API] Vertical Dpad P1 : " + Input.GetAxis("VerticalDpadP1"));
            VDP1 = true; 
        }
        else if (Input.GetAxis("VerticalDpadP1") != 0 && !VDP1)
        {
            Debug.Log("[Controller API] Vertical Dpad P1 : " + Input.GetAxis("VerticalDpadP1"));
            VDP1 = true;
        }
        else if (Input.GetAxis("VerticalDpadP1") == 0 && VDP1)
        {
            VDP1 = false;
        }

        if (Input.GetButtonDown("AButtonP1"))
        {
            Debug.Log("[Controller API] Button A P1");
        }
        
        if (Input.GetButtonDown("BButtonP1"))
        {
            Debug.Log("[Controller API] Button B P1");
        }
        
        if (Input.GetButtonDown("XButtonP1"))
        {
            Debug.Log("[Controller API] Button X P1");
        }
        
        if (Input.GetButtonDown("YButtonP1"))
        {
            Debug.Log("[Controller API] Button Y P1");
        }
        
        if (Input.GetButtonDown("BumperLeftP1"))
        {
            Debug.Log("[Controller API] Bumper Left P1");
        }
        
        if (Input.GetButtonDown("BumperRightP1"))
        {
            Debug.Log("[Controller API] Bumper Right P1");
        }
        
        if (Input.GetButtonDown("BackButtonP1"))
        {
            Debug.Log("[Controller API] Button Back P1");
        }
        
        if (Input.GetButtonDown("StartButtonP1"))
        {
            Debug.Log("[Controller API] Button Start P1");
        }
        
        if (Input.GetButtonDown("StickClickLeftP1"))
        {
            Debug.Log("[Controller API] Stick Click Left P1");
        }
        
        if (Input.GetButtonDown("StickClickRightP1"))
        {
            Debug.Log("[Controller API] Stick Click Right P1");
        }
    }
}
