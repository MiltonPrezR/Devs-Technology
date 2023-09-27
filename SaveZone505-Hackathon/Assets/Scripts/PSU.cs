using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSU
{
    private string pregunta;

    public string Pregunta
    {
        get => pregunta;
        set => pregunta = value;
    }

    public string []Respuesta
    {
        get => respuesta;
        set => respuesta = value;
    }

    private string[] respuesta;

    public int Opcion
    {
        get => opcion;
        set => opcion = value;
    }


    private int opcion;

    public PSU(string p, string[]  r, int o)
    {
        pregunta = p;
        respuesta = r;
        opcion = o;
    }
}
