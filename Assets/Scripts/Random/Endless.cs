using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endless : MonoBehaviour
{
    public GameObject player;
    public GameObject routes;
    public GameObject obstacle;
    public GameObject obstacle2;
    public GameObject coins;
    public int largeur;

    private int pos;
    private int lastplat;
    private float hauteur;
    private float idboxdemerde;
    private bool dash;
    private bool slide;
    private float coinspos;
    private int coinsfall;

    void Start()
    {
        coinsfall = 0;
        coinspos = 0;
        dash = true;
        slide = true;
        idboxdemerde = 0.01f;
        lastplat = 0;
        pos = 0;
        SpawnPlat(new Vector3(0, -5.5f));
        SpawnPlat(new Vector3(largeur, -5.5f - 0.01f));
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(dash);
        if (player.transform.position.x + 300 > pos)
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

            idboxdemerde += 0.01f;
            pos += largeur;
            SpawnPlat(new Vector3(largeur + pos, hauteur - idboxdemerde));


            if (Random.Range(0, 3) == 0 && slide)
            {
                SpawnObstacle(new Vector3(largeur + pos + 5, hauteur - idboxdemerde + 5.4f), obstacle);
                slide = false;
                StartCoroutine(slidetimer());
            }
            else if (Random.Range(0, 3) == 0 && dash)
            {
                SpawnObstacle2(new Vector3(largeur + pos + 5, hauteur - idboxdemerde + 5.4f), obstacle2);
                dash = false;
                StartCoroutine(dashtimer());
            }

            if (player.transform.position.x > coinspos)
            {
                Instantiate(coins, new Vector3(coinspos, 20, 0), Quaternion.identity);
                coinspos += 102.8f;
            }
        }
    }

    private void SpawnPlat(Vector3 spawnPosition)
    {
        Instantiate(routes, spawnPosition, Quaternion.identity);
    }

    private void SpawnObstacle(Vector3 spawnPosition, GameObject boom)
    {
        Instantiate(boom, spawnPosition, Quaternion.identity);
    }

    private void SpawnObstacle2(Vector3 spawnPosition, GameObject boom)
    {
        Instantiate(boom, spawnPosition, new Quaternion(0, 0, 0.7071f, 0.7071f));
    }

    IEnumerator dashtimer()
    {
        yield return new WaitForSeconds(2);
        dash = true;
    }

    IEnumerator slidetimer()
    {
        yield return new WaitForSeconds(2);
        slide = true;
    }
}
