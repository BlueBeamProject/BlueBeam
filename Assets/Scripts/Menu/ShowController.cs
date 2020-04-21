using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowController : MonoBehaviour
{
    
    private static GameObject JumpP1;
    private static GameObject SlideP1;
    private static GameObject AttackP1;
    private static GameObject DashP1;
    
    // Start is called before the first frame update
    void Start()
    {
        Refresh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Refresh()
    {
        JumpP1 = GameObject.FindGameObjectWithTag("JumpP1Button");
        JumpP1.GetComponent<Text>().text = SaveData.ReadValueString("JumpP1");
        
        SlideP1 = GameObject.FindGameObjectWithTag("SlideP1Button");
        SlideP1.GetComponent<Text>().text = SaveData.ReadValueString("SlideP1");
        
        AttackP1 = GameObject.FindGameObjectWithTag("AttackP1Button");
        AttackP1.GetComponent<Text>().text = SaveData.ReadValueString("AttackP1");
        
        DashP1 = GameObject.FindGameObjectWithTag("DashP1Button");
        DashP1.GetComponent<Text>().text = SaveData.ReadValueString("DashP1");
    }
}
