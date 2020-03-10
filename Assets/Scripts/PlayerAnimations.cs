using System;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private float fps;
    public ParticleSystem dust;
    private SpriteRenderer mySpriteRenderer;
    public Sprite[] frames;
    private int currentFrame;
    private float secondsToWait;
    private bool stopped;
    
    void Awake()
    {
        fps = 2F;
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        currentFrame = 1;
        if (fps > 0)
            secondsToWait = 1 / fps;
        else
            secondsToWait = 0;
        stopped = false;
    }

    void Play(bool reset = false)
    {
        if (reset)
            currentFrame = 1;

        stopped = false;
        mySpriteRenderer.enabled = true;

        if (frames.Length > 1)
            Animate();
        else if (frames.Length > 0)
            mySpriteRenderer.sprite = frames[0];
    }

    void Animate()
    {
        if(currentFrame >= frames.Length)
        {
            currentFrame = 0;
        }
 
        mySpriteRenderer.sprite = frames[currentFrame];
 
        if(!stopped) {
            currentFrame++;
        }
    }

    void Update()
    {
        Play();
    }

    public void CreateDust()
    {
        dust.Play();
    }
}