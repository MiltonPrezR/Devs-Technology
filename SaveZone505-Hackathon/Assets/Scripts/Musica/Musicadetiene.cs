using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicadetiene : MonoBehaviour
{
    private void Start() {
        GameObject.FindGameObjectWithTag("musica").GetComponent<MusicaContinua>().StopMusic();
    }
}
