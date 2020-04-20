using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerPhysics _myPhysics;
    private PauseMenu _myPause;
    // Start is called before the first frame update
    void Start()
    {
        _myPhysics = GetComponent<PlayerPhysics>();
        _myPause = GetComponent<PauseMenu>();
    }
    
    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        if (Input.GetKey(KeyCode.Space))
=======
        //if (Input.GetKeyDown(KeyCode.Escape))
            //SceneManager.LoadScene("Menu");


        if (Input.GetKeyDown(KeyCode.Space))
>>>>>>> Stashed changes
            _myPhysics.Jump();
        else
            _myPhysics.StopJump();

        if (Input.GetKeyDown(KeyCode.RightArrow))
            _myPhysics.Dash(1);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            _myPhysics.Dash(2);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            _myPhysics.Dash(3);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            _myPhysics.Dash(4);
    }
}
