using System.Text;
using System.Timers;
using System.Diagnostics;
using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mensaje : MonoBehaviour
{
    public Slider slider;
    int total = 0;

    [SerializeField] private int escenaActual;

    public Movimiento mov;
    public Animator animator;
    public float velocityPlayer;


    [SerializeField] public GameObject[] Panel;
    bool dañoR = false;
    public bool seguir = false;

    public Image img;

    void Start() {
        slider.value = 100;
        Panel[0].SetActive(false);
        Panel[1].SetActive(false);
        Panel[2].SetActive(false);
        Panel[3].SetActive(false);
        Panel[4].SetActive(false);
        Panel[5].SetActive(false);
    }
    void Update()
    {
        if(slider.value == 65)
        {
            img.color = Color.red;
            //img.color = new Color(RGBA[0], RGBA[1], RGBA[2], RGBA[3]);
        }
        else if(slider.value == 5)
        {
            img.color = Color.gray;
        }
    }
    public void BtnCama() {

        Panel[0].SetActive(false);

        Panel[1].SetActive(true);
    }

    public void BtnEspejo() {

        Panel[0].SetActive(false);

        Panel[2].SetActive(true);

        dañoR = true;

        if (dañoR)
            {
                StartCoroutine("Dano");
            }
    }
    IEnumerator Dano()
    {
        while(slider.value >= 50)
        {
            slider.value -= 1;
            yield return new WaitForSeconds(0.1f);
        }
        
    }
    IEnumerator Dano2()
    {
        while(slider.value <= 100 && seguir)
        {
            total += 1;
            slider.value -= 1;
            if(total == 50)
            {
                seguir = false;
                
            }
            yield return new WaitForSeconds(0.1f);
        }
        
    }
    public void btnContinuar() {

        animator.enabled = true;

        Panel[1].SetActive(false);
        MovimientoCamara.Instance.MoverCamara(0f, 0f, 0f);
    }

    public void btn_Continuar() {
        Panel[2].SetActive(false);
        animator.enabled = true;
        MovimientoCamara.Instance.MoverCamara(0f, 0f, 0f);
    }
    public void btnReiniciar() {
        SceneManager.LoadScene(escenaActual);
        MovimientoCamara.Instance.MoverCamara(0f, 0f, 0f);
    }

    //sismo 2

    public void BtnMesa() {

        Panel[3].SetActive(false);

        Panel[4].SetActive(true);
    }

    public void Btncorrer() {

        seguir = true;
        Panel[3].SetActive(false);

        Panel[5].SetActive(true);
        dañoR = true;
        
        if (dañoR)
            {
                StartCoroutine("Dano2");
            }
    }

    public void btnContinuar2() {

        animator.enabled = true;

        Panel[4].SetActive(false);
        MovimientoCamara.Instance.MoverCamara(0f, 0f, 0f);

        animator.enabled = true;
    }

    public void btn_Continuar2() {
        Panel[5].SetActive(false);
        animator.enabled = true;
        MovimientoCamara.Instance.MoverCamara(0f, 0f, 0f);
    }
}
