using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ViewGamer : MonoBehaviour
{
    private List<Jugador> rankingJugadores = new List<Jugador>();
    private string[] CurrentArray = null;
    public Transform tfPanelCargarDatos;
    public TextMeshProUGUI TextCargando;
    public GameObject panelPref;

    private void Start()
    {
        StartCoroutine(setPlayer());
    }

    IEnumerator setPlayer()
    {
        TextCargando.text = "Cargando...";
        WWW dataServer = new WWW("http://p1.test/server/ranking.php");
        yield return dataServer;

        if(dataServer.error != null)
        {
            Debug.Log("Problema en obtener a los jugadores" + dataServer.error);
            TextCargando.text = dataServer.error;
        }
        else
        {
            TextCargando.text = "";
            ObtenerRegistros(dataServer);
            verRegistros();
        }
    }
    void ObtenerRegistros(WWW dataServer)
    {
        CurrentArray = System.Text.Encoding.UTF8.GetString(dataServer.bytes).Split(";"[0]);

        for (int i = 0; i <= CurrentArray.Length - 3; i = i + 2)
        {
            rankingJugadores.Add(new Jugador(CurrentArray[i], CurrentArray[i + 1]));
        }
    }
    void verRegistros()
    {
        for (int i = 0; i < rankingJugadores.Count; i++)
        {
            GameObject obg = Instantiate(panelPref);
            Jugador jg = rankingJugadores[i];
            obg.GetComponent<SetScore>().setScore(jg.name, jg.score);
            obg.transform.SetParent(tfPanelCargarDatos);
            obg.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }
    } 
}
public class Jugador
{
    public string score;
    public string name;

    public Jugador (string nombreJugador, string scorePlayer)
    {
        score = scorePlayer;
        name = nombreJugador;
    }
}