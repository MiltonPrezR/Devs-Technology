using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juego : MonoBehaviour
{
    [SerializeField] private GameObject[] imagenes;
    [SerializeField] private GameObject[] imagenesBuenas;
    [SerializeField]
    private GameObject[] Panel;

    private int index;
    private int Index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarItem(bool resp)
    {
        if (!resp && index<imagenes.Length)
        {
            imagenes[index].SetActive(true);
            index++;
        }
        if(index>=imagenes.Length)
        {

            //Mandar a otra pantalla indicando porque perdio
            //Es complicado mencionar que elementos (No da tiempo para hacer el Script) fueron los malos, asi que es mejor ponerlos todos
            Panel[0].SetActive(true);
        }
    }
    public void validarItemBuenos(bool resp)
    {
        if (resp && Index < imagenesBuenas.Length)
        {
            Index++;
        }
        if(Index >= imagenesBuenas.Length)
        {

            Panel[1].SetActive(true);
        }
    }
}
