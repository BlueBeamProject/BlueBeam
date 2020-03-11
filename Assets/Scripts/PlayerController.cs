using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerPhysics _myPhysics;
    // Start is called before the first frame update
    void Start()
    {
        _myPhysics = GetComponent<PlayerPhysics>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            _myPhysics.Jump();
        else
        {
            _myPhysics.StopJump();
        }

        /*
       //Joystick1... pour manette xbox 
       //joystick2... pour manette type switch
       if (Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.Joystick2Button1))
       {
           Debug.Log("Button A");
       }
       
       if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Joystick2Button0))
       {
           Debug.Log("Button B");
       }
       
       if (Input.GetKeyDown(KeyCode.Joystick1Button2) || Input.GetKeyDown(KeyCode.Joystick2Button3))
       {
           Debug.Log("Button X");
       }
       
       if (Input.GetKeyDown(KeyCode.Joystick1Button3) || Input.GetKeyDown(KeyCode.Joystick2Button2))
       {
           Debug.Log("Button Y");
       }
       
       if (Input.GetKeyDown(KeyCode.Joystick1Button4) || Input.GetKeyDown(KeyCode.Joystick2Button4))
       {
           Debug.Log("Bumper Left");
       }
       
       if (Input.GetKeyDown(KeyCode.Joystick1Button5) || Input.GetKeyDown(KeyCode.Joystick2Button5))
       {
           Debug.Log("Bumper Right");
       }
       
       //uniquement pour xbox
       if (Input.GetKeyDown(KeyCode.Joystick1Button6))
       {
           Debug.Log("Back Button");
       }
       
       //uniquement pour xbox//
       if (Input.GetKeyDown(KeyCode.Joystick1Button7))
       {
           Debug.Log("Start Button");
       }
       
       if (Input.GetKeyDown(KeyCode.Joystick1Button8) || Input.GetKeyDown(KeyCode.Joystick2Button8))
       {
           Debug.Log("Joystick Left Click");
       }
       
       if (Input.GetKeyDown(KeyCode.Joystick1Button9) || Input.GetKeyDown(KeyCode.Joystick2Button9))
       {
           Debug.Log("Joystick Right Click");
       }
       
       //les valeurs varient de -1 à 1
       if (Input.GetAxis("Vertical") != 0)
       {
           Debug.Log("Axis Vertical left : " + Input.GetAxis("Vertical"));
       }
       
       if (Input.GetAxis("Horizontal") != 0)
       {
          Debug.Log("Axis horizontal right : " + Input.GetAxis("Horizontal"));
       }
       
       if (Input.GetAxis("3Axis") != 0)
       {
           Debug.Log("Axis 3axis : " + Input.GetAxis("3Axis"));
       }
       
       if (Input.GetAxis("4Axis") != 0)
       {
           Debug.Log("Axis Horizontal Right : " + Input.GetAxis("4Axis"));
       }
       
       if (Input.GetAxis("5Axis") != 0)
       {
           Debug.Log("Axis Vertical Left : " + Input.GetAxis("5Axis"));
       }
       
       if (Input.GetAxis("6Axis") != 0)
       {
           Debug.Log("Axis PAD Horizontal : " + Input.GetAxis("6Axis"));
       }
       
       if (Input.GetAxis("7Axis") != 0)
       {
           Debug.Log("Axis PAD Vertical : " + Input.GetAxis("7Axis"));
       }
       
       
       */
        
        
        
        
    }
}
