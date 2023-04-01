using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundtrackManager : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("SoundtrackManager").GetComponent<AudioSource>();
    }
    public void PlaySound(AudioClip clip, float volume)
    {
        audioSource.PlayOneShot(clip, volume);
    }
    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }
}
