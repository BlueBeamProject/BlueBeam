using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TextHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject text;
    private Text tm;
    // Start is called before the first frame update
    void Start()
    {
        print("start");

        tm = text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        print(text.GetComponent<Text>().fontSize);
        
        tm.fontSize = 50; //Or however you do your color
       // tm.color = Color.red;
        tm.fontStyle = FontStyle.Bold;
        print("i'm here");
    }
 
    public void OnPointerExit(PointerEventData eventData)
    {
        tm.fontSize = 35;
        tm.color = Color.white;
        tm.fontStyle = FontStyle.Normal;
    }
}
