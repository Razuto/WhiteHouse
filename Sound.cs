using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
[System.Serializable]

public class Sound 
{
    // Start is called before the first frame update
    public string name;
    public AudioClip clip;
    [Range(0f, 1f)]
    public float volume;
    [Range(0f,1f)]
    public float pitch;
    public bool loop;

    [HideInInspector]
    public AudioSource audioSource;

}
