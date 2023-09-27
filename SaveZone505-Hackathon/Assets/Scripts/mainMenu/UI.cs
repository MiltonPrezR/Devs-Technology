using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameObject[] CanvasUI;
    public int numeroScene;

    void Awake() {
        CanvasUI[0].SetActive(true);
        CanvasUI[1].SetActive(false);
        CanvasUI[2].SetActive(false);
        CanvasUI[3].SetActive(false);
    }

    public void canvas(GameObject CanvasPrincipal) {
        CanvasUI[0].SetActive(false);
        CanvasUI[1].SetActive(false);
        CanvasUI[2].SetActive(false);
        CanvasUI[3].SetActive(false);
        CanvasPrincipal.SetActive(true);
    }
    public void Jugar() {
        SceneManager.LoadScene(numeroScene);
    }

    public void Salir() {
        Application.Quit();
    }
}
