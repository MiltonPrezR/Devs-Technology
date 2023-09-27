using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidosFueraDentro : MonoBehaviour
{
    public AudioSource[] clip;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            clip[0].enabled = false;
            clip[1].enabled = true;
        }
    }
}
