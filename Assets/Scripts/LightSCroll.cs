using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSCroll : MonoBehaviour
{
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time < 23)
        {
            if ((Time.time % 7 <= 1.5 && Time.time < 8) || Time.time > 10.5) transform.position = new Vector3(transform.position.x - .075f, transform.position.y, transform.position.z);
            else if (Time.time < 5 || Time.time > 20) transform.position = startPos;
            else if (Time.time > 9.3) transform.position = new Vector3(transform.position.x + .075f, transform.position.y, transform.position.z);
        }
        else
        {
            if (Time.time % 7 <= 1.5) transform.position = new Vector3(transform.position.x - .075f, transform.position.y, transform.position.z);
            else transform.position = startPos;
        }
    }
}
