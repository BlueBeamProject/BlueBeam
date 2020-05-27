using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    private Vector3 _movement;
    private Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //_transform.position = Vector3.MoveTowards(_transform.position, player.transform.position, 1000);
        _transform.position = player.transform.position + offset;
    }

    void OnTriggerStay2D(Collider2D collider)
    {
      if (collider.gameObject.CompareTag("Ennemy"))
      {
            collider.gameObject.GetComponent<EnnemyComportment>().Die();
      }

      if (collider.gameObject.CompareTag("Obstacle"))
      {
            collider.gameObject.GetComponent<LaserShot>().Die();
      }
    }
}
