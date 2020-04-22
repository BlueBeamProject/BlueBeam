using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 _movement;
    private Transform _transform;
    public GameObject player;
    private float x;
    private float val;
    private float val2;
    private bool attendre;
    private bool arrivee;
    // Start is called before the first frame update
    void Start()
    {
        arrivee = false;
        attendre = true;
        x = 0;
        val = 0;
        val2 = 0;
        _movement = new Vector3(moveSpeed, 0, 0);
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (attendre)
            StartCoroutine(OneSecond());
        if (arrivee)
        {
            _transform.position += _movement * Time.deltaTime * moveSpeed;
            _transform.position = new Vector3(_transform.position.x + val, _transform.position.y + val2, _transform.position.z);
        }
        else if (player.transform.position.x + 10 < transform.position.x)
        {
            _transform.position += _movement * Time.deltaTime * (moveSpeed / 10 * (-1));
        }
        else
        {
            arrivee = true;
        }
    }
    IEnumerator OneSecond()
    {
        attendre = false;
        yield return new WaitForSeconds(0.1f);
        x += 0.5f;
        val = (Mathf.Sin(x)) / 30;
        val2 = (Mathf.Sin(x/2)) / 40;
        attendre = true;
    }
}
