using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectInt : MonoBehaviour
{
    [SerializeField] private BoxCollider2D[]    objectsBox;
    [SerializeField] private Rigidbody2D[]      objectsRb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("objectInte"))
        {
            for(int i = 0; i < objectsBox.Length; i++)
            {
                objectsBox[i].enabled = false;
                objectsRb[i].gravityScale = 0;
            }
        }
    }
}
