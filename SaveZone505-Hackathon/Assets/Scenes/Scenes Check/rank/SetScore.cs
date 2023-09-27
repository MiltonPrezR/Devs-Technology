using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetScore : MonoBehaviour
{
    public GameObject nameJ;
    public GameObject score;

    public void setScore(string nombreJugador, string scoreJugador)
    {
        nameJ.GetComponent<TextMeshProUGUI>().text = nombreJugador;
        score.GetComponent<TextMeshProUGUI>().text = scoreJugador;

    }
}
