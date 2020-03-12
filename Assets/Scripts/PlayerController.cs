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
        if (Input.GetKey(KeyCode.Space))
            _myPhysics.Jump();
        else
            _myPhysics.StopJump();

        if (Input.GetKeyDown(KeyCode.RightArrow))
            _myPhysics.Dash(1);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            _myPhysics.Dash(2);

        /*if (Input.GetKeyDown(KeyCode.LeftArrow))
            _myPhysics.Dash(1);
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            _myPhysics.Dash(2);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            _myPhysics.Dash(3);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            _myPhysics.Dash(4);*/
    }
}
