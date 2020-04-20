using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    public GameObject slow;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.25f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
