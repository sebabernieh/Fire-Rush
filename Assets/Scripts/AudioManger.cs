using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManger : MonoBehaviour
{
    public static AudioManger instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    public AudioSource[] music;
    public AudioSource[] sfx;

    public void PlayMusic(int trackNumber)
    {
        StopMusic();

        if (trackNumber < music.Length)
        {
            music[trackNumber].Play();
        }
    }

    public void StopMusic()
    {
        foreach (AudioSource track in music)
        {
            track.Stop();
        }
    }

    public void PlaySFX(int soundToPlay)
    {
        sfx[soundToPlay].Stop();
        sfx[soundToPlay].Play();
    }
}
