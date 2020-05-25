using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class KeyBind : MonoBehaviour
{
    private static Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();

    public  GameObject jump, slide, attack, dash;
    public  int PlayerID;

    private GameObject currentKey;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!keys.ContainsKey("JumpP"+PlayerID))
        {
            keys.Add("JumpP"+PlayerID, (KeyCode)SaveData.ReadValueInt("JumpP"+PlayerID));
        }
        
        
        if (!keys.ContainsKey("SlideP"+PlayerID))
        {
            keys.Add("SlideP"+PlayerID, (KeyCode)SaveData.ReadValueInt("SlideP"+PlayerID));
        }
        
        if (!keys.ContainsKey("AttackP"+PlayerID))
        {
            keys.Add("AttackP"+PlayerID, (KeyCode)SaveData.ReadValueInt("AttackP"+PlayerID));
        }
        
        if (!keys.ContainsKey("DashP"+PlayerID))
        {
            keys.Add("DashP"+PlayerID, (KeyCode)SaveData.ReadValueInt("DashP"+PlayerID));
        }
        
        jump.transform.GetChild(0).GetComponent<Text>().text = keys["JumpP"+PlayerID].ToString();
        slide.transform.GetChild(0).GetComponent<Text>().text = keys["SlideP"+PlayerID].ToString();
        attack.transform.GetChild(0).GetComponent<Text>().text = keys["AttackP"+PlayerID].ToString();
        dash.transform.GetChild(0).GetComponent<Text>().text = keys["DashP"+PlayerID].ToString();
    }

    public void RefreshDisp(int playerID)
    {
        
        Debug.Log(playerID);
        
        keys["JumpP"+playerID] = (KeyCode)SaveData.ReadValueInt("JumpP"+playerID);
        keys["SlideP"+playerID] = (KeyCode)SaveData.ReadValueInt("SlideP"+playerID);
        keys["AttackP"+playerID] = (KeyCode)SaveData.ReadValueInt("AttackP"+playerID);
        keys["DashP"+playerID] = (KeyCode)SaveData.ReadValueInt("DashP"+playerID);
        
        jump.transform.GetChild(0).GetComponent<Text>().text = keys["JumpP"+playerID].ToString();
        slide.transform.GetChild(0).GetComponent<Text>().text = keys["SlideP"+playerID].ToString();
        attack.transform.GetChild(0).GetComponent<Text>().text = keys["AttackP"+playerID].ToString();
        dash.transform.GetChild(0).GetComponent<Text>().text = keys["DashP"+playerID].ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        if (currentKey != null)
        {
            Event e = Event.current;
            if (e.isKey)
            {
                keys[currentKey.name] = e.keyCode;
                currentKey.transform.GetChild(0).GetComponent<Text>().text = e.keyCode.ToString();
                
                switch(currentKey.name)
                {
                    case "JumpButtonP1":
                        SaveData.WriteValueInt("JumpP1",(int)e.keyCode);
                        break;
                    case "SlideButtonP1":
                        SaveData.WriteValueInt("SlideP1", (int)e.keyCode);
                        break;
                    case "AttackButtonP1":
                        SaveData.WriteValueInt("AttackP1",(int)e.keyCode);
                        break;
                    case "DashButtonP1":
                        SaveData.WriteValueInt("DashP1",(int)e.keyCode);
                        break;
                    case "JumpButtonP2":
                        SaveData.WriteValueInt("JumpP2",(int)e.keyCode);
                        break;
                    case "SlideButtonP2":
                        SaveData.WriteValueInt("SlideP2", (int)e.keyCode);
                        break;
                    case "AttackButtonP2":
                        SaveData.WriteValueInt("AttackP2",(int)e.keyCode);
                        break;
                    case "DashButtonP2":
                        SaveData.WriteValueInt("DashP2",(int)e.keyCode);
                        break;
                    case "JumpButtonP3":
                        SaveData.WriteValueInt("JumpP3",(int)e.keyCode);
                        break;
                    case "SlideButtonP3":
                        SaveData.WriteValueInt("SlideP3", (int)e.keyCode);
                        break;
                    case "AttackButtonP3":
                        SaveData.WriteValueInt("AttackP3",(int)e.keyCode);
                        break;
                    case "DashButtonP3":
                        SaveData.WriteValueInt("DashP3",(int)e.keyCode);
                        break;
                    case "JumpButtonP4":
                        SaveData.WriteValueInt("JumpP4",(int)e.keyCode);
                        break;
                    case "SlideButtonP4":
                        SaveData.WriteValueInt("SlideP4", (int)e.keyCode);
                        break;
                    case "AttackButtonP4":
                        SaveData.WriteValueInt("AttackP4",(int)e.keyCode);
                        break;
                    case "DashButtonP4":
                        SaveData.WriteValueInt("DashP4",(int)e.keyCode);
                        break;
                    default:
                        Debug.Log("tu t'es fail bro + " + currentKey.name);
                        break;
                }
                
                currentKey = null;
            }

            PlayerController.ReloadControl();
        }
    }

    public void ChangeKey(GameObject clicked)
    {
        currentKey = clicked;
    }
    
    public void DefaultPlayer1()
    {
        PlayerPrefs.SetInt("JumpP1", 32);
        PlayerPrefs.SetInt("SlideP1", 115);
        PlayerPrefs.SetInt("AttackP1", 100);
        PlayerPrefs.SetInt("DashP1", 102);
        
        RefreshDisp(1);

    }
    
    public void DefaultPlayer2()
    {
        PlayerPrefs.SetInt("JumpP2", 273);
        PlayerPrefs.SetInt("SlideP2", 274);
        PlayerPrefs.SetInt("AttackP2", 275);
        PlayerPrefs.SetInt("DashP2", 276);

        RefreshDisp(2);
    }
    
    public void DefaultPlayer3()
    {
        PlayerPrefs.SetInt("JumpP3", 13);
        PlayerPrefs.SetInt("SlideP3", 106);
        PlayerPrefs.SetInt("AttackP3", 108);
        PlayerPrefs.SetInt("DashP3", 109);
        
        RefreshDisp(3);

    }
    
    public void DefaultPlayer4()
    {
        PlayerPrefs.SetInt("JumpP4", 116);
        PlayerPrefs.SetInt("SlideP4", 97);
        PlayerPrefs.SetInt("AttackP4", 122);
        PlayerPrefs.SetInt("DashP4", 101);
        
        RefreshDisp(4);

    }
    
    
}
