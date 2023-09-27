using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnSonido : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource fuente;

    public void ReproducirSonido()
    {
        MusicaContinua.__instance.Play(clip, fuente);
    }
}
