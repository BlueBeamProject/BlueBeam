using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigureManettePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public int PlayerNumber;

    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    
    
    private bool configure = false;
    void Start()
    {

        for (int i = 1; i <= PlayerNumber; i++)
        {
            
        }
        
        
       /* while (!configure && Input.GetKeyDown("echap"))
        {
            Debug.Log("bite");
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
