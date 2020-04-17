using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
    public PlayerController thePlayer;
    private Vector3 lastPlayerPosition;
    private float distanceToMove;
    
    public float power = 0.7f;
    public float duration = 1.0f;
    public Transform camera;
    public float slowDownAmount = 1.0f;
    public bool shouldShake = false;
    public bool pos = true;
    public float ini;

    private Vector3 startPosition;

    private float initialDuration;

    public float a;
    
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPosition = thePlayer.transform.position;
        ini = thePlayer.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        camera = Camera.main.transform;
        startPosition = camera.localPosition;
        initialDuration = duration;
        if (shouldShake)
        {
            if (pos)
            {
                a = transform.position.y;
                pos = false;
            }
            if (duration > 0)
            {
                camera.localPosition = startPosition + Random.insideUnitSphere * power;
                duration -= Time.deltaTime * slowDownAmount;
            }
            else
            {
                shouldShake = false;
                duration = initialDuration;
                camera.localPosition = startPosition;
                
                transform.position = new Vector3(thePlayer.transform.position.x - ini, a, transform.position.z);
            }
        }
        else
        {
            pos = true;
            duration = 1.0f;
        }
    }
}
