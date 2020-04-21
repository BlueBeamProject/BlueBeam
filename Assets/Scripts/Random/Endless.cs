using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endless : MonoBehaviour
{
    public GameObject player;
    public GameObject routes;
    public int largeur;

    private int pos;
    private int lastplat;
    private float hauteur;

    void Start()
    {
        lastplat = 0;
        pos = 0;
        SpawnPlat(new Vector3(0, -5.5f));
        SpawnPlat(new Vector3(largeur, -5.5f));
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > pos)
        {
            if (lastplat == 0)
            {
                hauteur = -5.5f;
                lastplat = Random.Range(0, 2);
            }
            else if (lastplat == 1)
            {
                hauteur = -3.8f;
                lastplat = Random.Range(0, 3);
            }
            else
            {
                hauteur = -2.1f;
                lastplat = Random.Range(0, 4);
            }
            pos += largeur;
            SpawnPlat(new Vector3(largeur+pos, hauteur));
        }
    }

    private void SpawnPlat(Vector3 spawnPosition)
    {
        Instantiate(routes, spawnPosition, Quaternion.identity);
    }
}
