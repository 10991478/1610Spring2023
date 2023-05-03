using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*this script is for playing sounds/audios

FUNCTION KEY:
    PlaySound(AudioClip clip, float volume)
        plays an AudioClip at a chosen volume
    PlaySound(Audio clip)
        plays an AudioClip at full volume
    StopMusic()
        stops the clip that the AudioSource is currently playing
*/
public class SoundtrackManager : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("SoundtrackManager").GetComponent<AudioSource>();
    }
    public void PlaySound(AudioClip clip, float volume) //plays an AudioClip at a chosen volume
    {
        audioSource.PlayOneShot(clip, volume);
    }
    public void PlaySound(AudioClip clip) //plays an AudioClip at full volume
    {
        audioSource.PlayOneShot(clip);
    }

    public void StopMusic() //stops the clip that the AudioSource is currently playing
    {
        audioSource.Stop();
    }
}
