using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject logo;

    private Vector2 startPos;
    private bool laser;
    private bool logob;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        laser = true;
        logob = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (logob && Time.timeSinceLevelLoad > 21)
        {
            logo.SetActive(true);
        }

        if (laser && Time.timeSinceLevelLoad > 19.7 && Time.timeSinceLevelLoad < 23.207)
        {
            //19.625 et 25.207
            laser = false;
            StartCoroutine(Move());
        }
    }

    IEnumerator Move()
    {
        while (transform.position.x > -55)
        {
            yield return new WaitForSeconds(0.01f);
            transform.position += new Vector3(-0.7f, 0, 0);
        }
    }
}
