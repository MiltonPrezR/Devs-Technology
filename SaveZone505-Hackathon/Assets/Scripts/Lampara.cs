using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lampara : MonoBehaviour
{
    public BoxCollider2D bc;
    public Rigidbody2D rb2D;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            bc.enabled = false;
            Destroy(rb2D);
        }
    }
}
