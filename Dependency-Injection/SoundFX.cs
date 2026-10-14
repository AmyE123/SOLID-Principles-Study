using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour, ISoundPlayer
{
    public AudioSource audioSource;

    public void PlaySound(AudioClip soundFX)
    {
        audioSource.PlayOneShot(soundFX);
    }

}
