using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ImageHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject text;
    private Image im;
    // Start is called before the first frame update
    void Start()
    {
        print("start");

        im = text.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        
        im.rectTransform.sizeDelta = new Vector2(150,150);
        
    }
 
    public void OnPointerExit(PointerEventData eventData)
    {
        im.rectTransform.sizeDelta = new Vector2(100,100);
    }
}
