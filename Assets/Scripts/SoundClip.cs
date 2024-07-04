using System;
using UnityEngine;
using UnityEngine.Audio;

[Serializable]
public class SoundClip
{
    public string Name;
    public AudioClip Clip;
    [Range(0f, 1f)] 
    public float Volume;
    [Range(0.1f, 3f)] 
    public float Pitch;

    [HideInInspector] 
    public AudioSource AudioSource;
}