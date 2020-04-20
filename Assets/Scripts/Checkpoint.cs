using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject player;
    private Transform _transformPlayer;
    public GameObject camera;
    private Transform _transformCamera;

    // Start is called before the first frame update
    void Start()
    {
        _transformPlayer = player.GetComponent<Transform>();
        _transformCamera = camera.GetComponent<Transform>();

        if (SaveData.ReadValueInt("checkpoint1") == 1)
        {
        _transformPlayer.position += new Vector3(200, 0, 0);
        _transformCamera.position += new Vector3(200, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_transformPlayer.position.x > 200)
          SaveData.WriteValueInt("checkpoint1", 1);
    }
}
