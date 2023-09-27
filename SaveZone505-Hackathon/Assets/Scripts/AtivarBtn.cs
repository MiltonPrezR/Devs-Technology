using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtivarBtn : MonoBehaviour
{

    [SerializeField] private GameObject btn;
   private void OnTriggerEnter2D(Collider2D other)
   {
       if (other.gameObject.tag == "Player")
       {
        btn.SetActive(true);
       }
   }

   private void OnTriggerExit2D(Collider2D other)
   {
    if (other.gameObject.tag == "Player")
    {
        btn.SetActive(false);
    }
   }
}
