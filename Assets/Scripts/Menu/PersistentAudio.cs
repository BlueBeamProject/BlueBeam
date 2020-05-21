using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentAudio : MonoBehaviour
{
     private AudioSource _audioSource;
     private bool music = false;
     private void Awake()
     {
         //Debug.Log("Awake music : " + music);
         //DontDestroyOnLoad(transform.gameObject);
         _audioSource = GetComponent<AudioSource>();
         if (!music)
         {
             PlayMusic();
             music = true;
         }
         
         //Debug.Log("AwakeLatter music : " + music);*/
     }
 
     public void PlayMusic()
     {
         
         if (_audioSource.isPlaying) return;
         _audioSource.Play();
     }
 
     public void StopMusic()
     {
         _audioSource.Stop();
     }
}
