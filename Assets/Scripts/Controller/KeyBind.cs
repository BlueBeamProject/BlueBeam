using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class KeyBind : MonoBehaviour
{
    private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();

    public GameObject jump, slide, attack, dash;

    private GameObject currentKey;
    
    // Start is called before the first frame update
    void Start()
    {
        keys.Add("JumpP1", (KeyCode)SaveData.ReadValueInt("JumpP1"));
        keys.Add("SlideP1", (KeyCode)SaveData.ReadValueInt("SlideP1"));
        keys.Add("AttackP1", (KeyCode)SaveData.ReadValueInt("AttackP1"));
        keys.Add("DashP1", (KeyCode)SaveData.ReadValueInt("DashP1"));

        jump.transform.GetChild(0).GetComponent<Text>().text = keys["JumpP1"].ToString();
        slide.transform.GetChild(0).GetComponent<Text>().text = keys["SlideP1"].ToString();
        attack.transform.GetChild(0).GetComponent<Text>().text = keys["AttackP1"].ToString();
        dash.transform.GetChild(0).GetComponent<Text>().text = keys["DashP1"].ToString();
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
    
}
