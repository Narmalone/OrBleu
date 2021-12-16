using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sounds
{
    public AudioClip clip;

    public string name;
    [Range(0f,1f)]
    public float volume;

    [HideInInspector]
    public AudioSource source;

}
