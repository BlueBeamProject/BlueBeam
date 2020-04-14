using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 _movement;
    private Transform _transform;

    // Start is called before the first frame update
    void Start()
    {
        _movement = new Vector3(moveSpeed, 0, 0);
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _transform.position += _movement * Time.deltaTime * moveSpeed;
    }
}
