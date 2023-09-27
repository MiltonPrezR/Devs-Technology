using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaContinua : MonoBehaviour
{
    public static MusicaContinua __instance;
    private AudioSource __audioSource;

    private void Awake()
    {
        if (__instance == null)
        {
            __instance = this;
            DontDestroyOnLoad(gameObject);
            __audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void playMuysic()
    {
        if (__audioSource.isPlaying) return;
        __audioSource.Play();
    }

    public void Play(AudioClip a, AudioSource f)
    {
        f.clip = a;
        f.Play();
    }

    public void StopMusic()
    {
        __audioSource.Stop();
    }
}
