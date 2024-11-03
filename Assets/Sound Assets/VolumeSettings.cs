using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider musicSlider;

    public void SetMusicVolume()
    {
        float volumesettings = musicSlider.value;
        audioMixer.SetFloat("Music", Mathf.Log10(volumesettings)*20);
    }
}
