using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptDialogue : MonoBehaviour
{
    
    [Header("Efecxtos de sonidos")]
    public AudioClip[] Audioclip;

    [Header("Atributos de Unity")]
    
    //Pregunta
    [SerializeField]
    private TextMeshProUGUI TextPregunta;
    [SerializeField]
    public GameObject ObjetoPregunta;

    //Respuestas
    [SerializeField]
    private TextMeshProUGUI [] TextRespuestas;
    [SerializeField]
    public GameObject [] ObjetoRespuestas;
    
    //Imagenes de resultado de las respuestas
    [SerializeField]
    public GameObject [] BienMal;
    //Bot[on de siguiente
    [SerializeField] 
    public GameObject Next;


    [Header("Atributos propios")]
    //Preguntas puestas desde el inspector
    [SerializeField]
    public string[] Preguntas;
    //Objetos de tipo PSU
    private PSU []_preguntas;
    
    private int index;

    public int Index
    {
        get { return index; }
        set { index = value; }
    }

    private int AnimacionActivada;

    public bool BAND;
    public bool BAND_CONSTESTAR;
    [SerializeField]
    private string[] retroalimentacion;

    public string cadenaTexto = "";

    // Start is called before the first frame update
    void Start()
    {
        instanciarObjetosPregunta();
        index = 0;
        AsignarDatos();
        BAND = false;
    }

    void instanciarObjetosPregunta()
    {
        _preguntas = new PSU[Preguntas.Length];
        
        for (int i = 0; i < Preguntas.Length; i++)
        {
            string []datos = Preguntas[i].Split('-');
            string[] r = new string[3];
            r[0] = datos[1];
            r[1] = datos[2];
            r[2] = datos[3];

            _preguntas[i] = new PSU(datos[0], r.Clone() as string[], Convert.ToInt32(datos[4]));
        }
    }

    public void AsignarDatos()
    {
        TextPregunta.text = _preguntas[index].Pregunta;
        for (int i = 0; i < _preguntas[index].Respuesta.Length; i++)
        {
            TextRespuestas[i].text = _preguntas[index].Respuesta[i];
        }

        BAND_CONSTESTAR = true;
    }

    public void validarRespuesta(int indiceRespuesta)
    {
        if (BAND_CONSTESTAR)
        {
            if (TextRespuestas[indiceRespuesta].text == _preguntas[index].Respuesta[_preguntas[index].Opcion])
            {
                BienMal[0].SetActive(true);
                AnimacionActivada = 0;
            }
            else
            {
                BienMal[1].SetActive(true);
                AnimacionActivada = 1;

                cadenaTexto += $"Pregunta { index+1 }: { retroalimentacion[index] } \n";
            }
            Invoke("ActivarNext", 1f);
        }

        BAND_CONSTESTAR = false;
    }

    public void ActivarNext()
    {
        Next.SetActive(true);
        BAND = true;
    }
    
    bool isAnimationStatePlaying(Animator anim, int animLayer, string stateName)
    {
        if (anim.GetCurrentAnimatorStateInfo(animLayer).IsName(stateName) &&
            anim.GetCurrentAnimatorStateInfo(animLayer).normalizedTime < 1.0f)
            return true;
        else
            return false;
    }

    public void ClicNext()
    {
       
            Next.GetComponent<Animator>().SetBool("Idle", false);
            Next.GetComponent<Animator>().SetBool("Clic", true);
            BienMal[AnimacionActivada].GetComponent<Animator>().SetBool("Salir", true);
            ObjetoPregunta.GetComponent<Animator>().SetBool("Salir", true);
        
            foreach (var objetos in ObjetoRespuestas)
            {
                objetos.GetComponent<Animator>().SetBool("Salir", true);
            }
        
    }

    private void Update()
    {
        if (BAND)
        {
            if (!isAnimationStatePlaying(Next.GetComponent<Animator>(), 0, "EntrarSiguiente"))
            {
                BAND = false;
            }
        }
    }
}
