using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntreCanvas : MonoBehaviour
{
    public GameObject[] Canvas1;

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag == "Player") {

            Canvas1[2].SetActive(true);
        }
    }
}
