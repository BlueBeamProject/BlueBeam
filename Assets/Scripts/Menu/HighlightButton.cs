using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HighlightButton : MonoBehaviour
{
    

    public GameObject gameObjectt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnter()
    {
        
        Debug.Log("Show");
        gameObjectt.SetActive(true);
    }

    public void OnExit()
    {
        
        Debug.Log("Unshow");
        gameObjectt.SetActive(false);
    }

    
}
