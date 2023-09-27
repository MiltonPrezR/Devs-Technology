using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class mochila : MonoBehaviour
{
    [Header("TextMeshProUGUI")]
    public TextMeshProUGUI textSuma;
    public TextMeshProUGUI[] textNombres;

    [Header("GameObjects")]
    public GameObject panel;
    public GameObject btns;

    //Valores enteros
    int suma = 0;
    int contador = 0;

    public void BtnBueno(Button Milton)
    {
        suma += 5;
        Milton.enabled = false;
        contador++;

        btns.SetActive(true);
    }
    public void BtnNombre(TextMeshProUGUI Milton)
    {
        if(contador > 1) textNombres[0].text = $"Has tomado {contador} Objetos";
        else textNombres[0].text = $"Has tomado {contador} Objeto";

        textNombres[1].text += $"{Milton.text} - ";
    }
    public void BtnMalo(Button Milton)
    {
        if (suma > 0)
        {
            suma -= 5;
        }
        Milton.enabled = false;
        contador++;

        btns.SetActive(true);
    }
    public void BtnConfirmar()
    {
        panel.SetActive(true);
        btns.SetActive(false);

        if(suma >= 15)
        {
            textSuma.text = $"Obtuvistes {suma} puntos, Exelente.";
        }
        else if(suma == 10)
        {
            textSuma.text = $"Obtuvistes {suma} puntos, muy bien.";
        }
        else
        {
            textSuma.text = $"Obtuvistes {suma} puntos, mal.";
        }
    }

    public void Comenzar(GameObject PanelActual)
    {
        PanelActual.SetActive(false);
    }
}
