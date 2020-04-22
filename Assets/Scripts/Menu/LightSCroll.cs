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
        if (Time.timeSinceLevelLoad < 23)
        {
            if ((Time.timeSinceLevelLoad % 7 <= 1.5 && Time.timeSinceLevelLoad < 8) || Time.timeSinceLevelLoad > 10.5) transform.position = new Vector3(transform.position.x - .075f, transform.position.y, transform.position.z);
            else if (Time.timeSinceLevelLoad < 5 || Time.timeSinceLevelLoad > 20) transform.position = startPos;
            else if (Time.timeSinceLevelLoad > 9.3) transform.position = new Vector3(transform.position.x + .075f, transform.position.y, transform.position.z);
        }
        else
        {
            if (Time.timeSinceLevelLoad % 7 <= 1.5) transform.position = new Vector3(transform.position.x - .075f, transform.position.y, transform.position.z);
            else transform.position = startPos;
        }
    }
}
