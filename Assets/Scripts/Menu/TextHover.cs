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
        tm = text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        
        tm.fontSize = 50; 
        tm.fontStyle = FontStyle.Bold;
    }
 
    public void OnPointerExit(PointerEventData eventData)
    {
        tm.fontSize = 35;
        tm.fontStyle = FontStyle.Normal;
    }
}
