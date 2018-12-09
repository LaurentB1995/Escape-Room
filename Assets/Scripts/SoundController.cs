using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public GameObject soundSystem;
    public AudioClip audioClip;

    private AudioSource[] intercoms;
    private bool soundPlayed = false;

    void Start()
    {
        intercoms = soundSystem.GetComponentsInChildren<AudioSource>();
        if (gameObject.name.Equals("Player"))
        {
            PlayAudio();
        }
    }

    public void PlayAudio()
    {
        if (!soundPlayed)
        {
            foreach (AudioSource source in intercoms)
            {
                if (!source.isPlaying)
                {
                    source.PlayOneShot(audioClip);
                    soundPlayed = true;
                }
            }
        }
    }
}
