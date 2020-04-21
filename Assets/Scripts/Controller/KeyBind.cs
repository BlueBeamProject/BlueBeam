using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class KeyBind : MonoBehaviour
{
    private Dictionary<string, string> keys = new Dictionary<string, string>();

    public GameObject jump, slide, attack, dash;

    private GameObject currentKey;
    
    // Start is called before the first frame update
    void Start()
    {
        keys.Add("JumpP1", SaveData.ReadValueString("JumpP1"));
        keys.Add("SlideP1", SaveData.ReadValueString("SlideP1"));
        keys.Add("AttackP1", SaveData.ReadValueString("AttackP1"));
        keys.Add("DashP1", SaveData.ReadValueString("DashP1"));

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
                keys[currentKey.name] = e.keyCode.ToString();
                currentKey.transform.GetChild(0).GetComponent<Text>().text = e.keyCode.ToString();
                
                switch(currentKey.name)
                {
                    case "JumpButtonP1":
                        SaveData.WriteValueString("JumpP1",e.keyCode.ToString().ToLower());
                        Debug.Log("héhé : " +SaveData.ReadValueString("JumpP1"));
                        break;
                    case "SlideButtonP1":
                        SaveData.WriteValueString("SlideP1", e.keyCode.ToString().ToLower());
                        break;
                    case "AttackButtonP1":
                        SaveData.WriteValueString("AttackP1",e.keyCode.ToString().ToLower());
                        break;
                    case "DashButtonP1":
                        SaveData.WriteValueString("DashP1",e.keyCode.ToString().ToLower());
                        break;
                    default:
                        Debug.Log("tu t'es fail bro + " + currentKey.name);
                        break;
                }
                
                currentKey = null;
            }
        }
    }

    public void ChangeKey(GameObject clicked)
    {
        currentKey = clicked;
    }
    
}
