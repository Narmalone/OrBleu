using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class audioManager : MonoBehaviour
{
    public Sound[] sounds;
    void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        s.source.Play();
    }

}