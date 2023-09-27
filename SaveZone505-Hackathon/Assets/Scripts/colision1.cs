using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class colision1 : MonoBehaviour
{
    public Movimiento mov;
    public Animator animator;
    public GameObject[] objectos;

    public void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Player")
        {
            
            objectos[0].SetActive(true);
            MovimientoCamara.Instance.MoverCamara(2f, 3f, 3f);

            animator.enabled = false;
            
            Destroy(gameObject);
        }
    }
}