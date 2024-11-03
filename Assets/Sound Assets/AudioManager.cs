using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; set; }
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SoundEffectSource;
    //private AudioSource soundeffectSource;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        //DontDestroyOnLoad(this);
       // if (instance == null)
        //{
        //    instance = this;
        //}
        //else
        //    Destroy(gameObject);
        //}
    }
    private void Start()
    {
        musicSource.Play();
    }

    public void ClickButtonEffect()
    {
        SoundEffectSource.Play();
    }
}
