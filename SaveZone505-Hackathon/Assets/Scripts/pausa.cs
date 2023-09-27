using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausa : MonoBehaviour
{
    [SerializeField] private GameObject botonpausa;
    [SerializeField] private GameObject menupausa;
    [SerializeField] private GameObject btnMovimiento;

    void Start()
    {
        reanudar();
    }


    public void Pausa()
    {
        Time.timeScale = 0f;
        botonpausa.SetActive(false);
        menupausa.SetActive(true);
        btnMovimiento.SetActive(false);

    }


    public void reanudar()
    {
        Time.timeScale = 1f;
        botonpausa.SetActive(true);
        menupausa.SetActive(false);
        btnMovimiento.SetActive(true);
    }

    public void restar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        btnMovimiento.SetActive(true);
    }
    public void salir(int salir) {
        Time.timeScale = 1f;
        SceneManager.LoadScene(salir);
    }
}
