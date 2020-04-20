using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public PlayerController thePlayer;

	private Vector3 lastPlayerPosition;
	private float distanceToMove;
    // Start is called before the first frame update
    void Start()
    {
		thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPosition = thePlayer.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
		distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;
		transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);
        lastPlayerPosition = thePlayer.transform.position;
=======
        
        if (!death)
        {
            _transform.position += _movement * Time.deltaTime * moveSpeed;
            gameOver.SetActive(false);
        }
        
        else
        {
            _transform.position += _movement * Time.deltaTime * (moveSpeed / 10 * (-1));
            gameOver.SetActive(true);
        }
    }

    public static void Death()
    {
        death = true;
>>>>>>> Stashed changes
    }
}
