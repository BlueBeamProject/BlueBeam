using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyComportment : MonoBehaviour
{
    public Transform target;
    public float range = 15f;
    public string ennemyTargetTag = "Player";
    void Start()
    {
        Invoke("UpdateTarget", 0f);
    }

    
    void Update()
    {
        GameObject[] ennemies = GameObject.FindGameObjectsWithTag(ennemyTargetTag);
    }
}
