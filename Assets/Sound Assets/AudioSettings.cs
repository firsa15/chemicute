using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AudioSettings : MonoBehaviour
{
    public static AudioSettings instance {  get; set; }

    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;

    [Header("Audio Clip")]
    public AudioClip musicClip;
    void Start()
    {
        musicSource.clip = musicClip;
        musicSource.Play();
    }
}
