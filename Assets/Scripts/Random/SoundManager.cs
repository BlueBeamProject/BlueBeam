using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip jumpSound;
    public AudioClip landSound;

    private AudioSource audioSrc;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump()
    {
        audioSrc.PlayOneShot(jumpSound);
    }

    public void Land()
    {
        audioSrc.PlayOneShot(landSound);
    }
}
