using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerPhysics _myPhysics;
    // Start is called before the first frame update
    void Start()
    {
        _myPhysics = GetComponent<PlayerPhysics>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _myPhysics.Jump();
            
        if (Input.GetKeyDown(KeyCode.S))
            _myPhysics.Slide();

        if (Input.GetKeyDown(KeyCode.D))
            _myPhysics.Attack();

        if (Input.GetKeyDown(KeyCode.G))
            _myPhysics.Shild();
    }
}
