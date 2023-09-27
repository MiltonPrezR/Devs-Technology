using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicaplay : MonoBehaviour
{
    private void Start() {
        GameObject.FindGameObjectWithTag("musica").GetComponent<MusicaContinua>().playMuysic();
    }
}
