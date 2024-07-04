using System.Collections;
using System.Collections.Generic;
using System;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private SoundClip[] _soundClips;
    public static AudioManager Instance;
    private void Awake()
    {
        Instance = this;
        foreach (SoundClip soundClip in _soundClips)
        {
            AudioSource audioSource = soundClip.AudioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = soundClip.Clip;
            audioSource.volume = soundClip.Volume;
            audioSource.pitch = soundClip.Pitch;
            audioSource.playOnAwake = false;
        }
    }


    public void PlaySound(string name)
    {
        Debug.Log(name);
        SoundClip soundClip = Array.Find(_soundClips, sound => sound.Name == name);
        soundClip.AudioSource.Play();
    }
}
