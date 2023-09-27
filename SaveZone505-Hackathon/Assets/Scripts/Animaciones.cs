using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Animaciones : MonoBehaviour
{
    [SerializeField]
    private ScriptDialogue dialogo;

    [SerializeField] private GameObject Panel;
    
    public void Activar()
    {
        dialogo.Index++;
        if (dialogo.Index < dialogo.Preguntas.Length)
        {
            dialogo.ObjetoPregunta.GetComponent<Animator>().SetBool("Salir", false);

            foreach (var objeto in dialogo.ObjetoRespuestas)
            {
                objeto.GetComponent<Animator>().SetBool("Salir", false);
            }
        
            dialogo.BienMal[0].SetActive(false);
            dialogo.BienMal[1].SetActive(false);
            dialogo.Next.SetActive(false);
            dialogo.BAND = false;
            dialogo.AsignarDatos();
        }
        else
        {
            Panel.SetActive(true);
            if (dialogo.cadenaTexto.Equals(""))
            {
                //Felicidades todas tus respuestas fueron correctas
                Panel.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Felicidades, has respondido correctamente todas las preguntas";
            }
            else
            {
                Panel.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = dialogo.cadenaTexto;
            }
        }
        
        
    }

    public void ActivarAnimacionNext()
    {
        dialogo.Next.GetComponent<Animator>().SetBool("Idle", true);
        
    }
    
}
