using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class colision : MonoBehaviour
{
    //public Animator animator;

    public BoxCollider2D stanLibros;

    public static colision boleano;
    public Rigidbody2D[] rb2D;
    public float speed;
    public Vector3 rotacion;
    public float velocidad;

    void Awake(){
        rb2D[0].GetComponent<Rigidbody2D>();
        rb2D[1].GetComponent<Rigidbody2D>();
    }

    public void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Player")
        {
            //stanLibros.transform.Rotate(0, 0, 43.695f * 1.7f);
            MovimientoCamara.Instance.MoverCamara(3f, 4f, 6f);

            speed += 0.3f;
            rb2D[0].gravityScale = speed;
            rb2D[0].transform.Rotate(rotacion * velocidad * Time.deltaTime);

            rb2D[1].gravityScale = speed;
            rb2D[1].transform.Rotate(rotacion * velocidad * Time.deltaTime);
            
            rb2D[2].gravityScale = speed;
            rb2D[2].transform.Rotate(rotacion * velocidad * Time.deltaTime);
            
            //animator.enabled = false;
            
            Destroy(gameObject);
        }
    }
}