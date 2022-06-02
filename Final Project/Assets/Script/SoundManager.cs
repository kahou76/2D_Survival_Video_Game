using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance { get; private set; }
    private AudioSource source;
    private AudioSource source1;

    public void Awake()
    {
        instance = this;
        source = GetComponent<AudioSource>();
        source1 = GetComponent<AudioSource>();
    }
    public void PlaySound(AudioClip _sound)
    {
        source.PlayOneShot(_sound); 
    }

    public void PlayBackground(AudioClip _sound1)
    {
        source1.clip = _sound1;
        source1.Play();
    }

    public void PauseSound()
    {
        source1.Stop();
        //Destroy(source);
    }
}
