using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarComponente : MonoBehaviour
{
    public BoxCollider2D[] bc;
    public Rigidbody2D[] rb2D;

    private void OnTriggerEnter2D(Collider2D colision) {
        if(colision.gameObject.tag == "Cae") {
            bc[0].enabled = false;
            bc[1].enabled = false;

            Destroy(rb2D[0]);
            Destroy(rb2D[1]);

            bc[2].enabled = false;
            bc[3].enabled = false;

            Destroy(rb2D[2]);
            Destroy(rb2D[3]);

            bc[4].enabled = false;
            bc[5].enabled = false;

            Destroy(rb2D[4]);
            Destroy(rb2D[5]);

            bc[6].enabled = false;

            Destroy(rb2D[6]);
        }
    }
}
