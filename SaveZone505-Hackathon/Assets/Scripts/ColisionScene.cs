using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColisionScene : MonoBehaviour
{
    public GameObject panel;
    public GameObject btn;

    void Start()
    {
        panel.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            panel.SetActive(true);
            btn.SetActive(false);
        }
    }
}
