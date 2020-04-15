using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 _movement;
    private Transform _transform;
    static bool death;

    // Start is called before the first frame update
    void Start()
    {
        _movement = new Vector3(moveSpeed, 0, 0);
        _transform = GetComponent<Transform>();
        death = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!death)
            _transform.position += _movement * Time.deltaTime * moveSpeed;
    }

    public static void Death()
    {
        death = true;
    }
}
