using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activer : MonoBehaviour
{

    public GameObject toactive;
    public string tag;
    // Start is called before the first frame update
    void Start()
    {
        toactive.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag(tag))
        {
            toactive.SetActive(true);
        }
    }
}
