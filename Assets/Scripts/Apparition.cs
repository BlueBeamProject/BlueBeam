using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apparition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color (1, 1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 20) GetComponent<SpriteRenderer>().color = new Color (1, 1, 1, 0.35f);
    }
}
