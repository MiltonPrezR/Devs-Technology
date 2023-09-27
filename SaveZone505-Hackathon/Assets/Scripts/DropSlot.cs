using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private Transform Mochila;
    public GameObject item;
    [SerializeField]
    private Transform parent;
    [SerializeField]
    private Juego juego;
    public GameObject[] objetos;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Mochila.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
            
        }
    }
    
    public void OnDrop(PointerEventData eventData)
    {
        /*objetos[0] = GameObject.FindGameObjectWithTag("Buenos");
        if (objetos[0] != null)
        {
            Debug.Log("Hola");
        }*/
        item = DragDrop.itemDragging;
        item.transform.SetParent(parent);
        item.transform.position = transform.position;
        DragDrop.MochilaAnimator.SetInteger("Pasar", 0);
        juego.validarItem(DragDrop.itemDragging.GetComponent<DragDrop>().respuesta);
        juego.validarItemBuenos(DragDrop.itemDragging.GetComponent<DragDrop>().respuesta);
        DragDrop.itemDragging.GetComponent<DragDrop>().enabled = false;
        
    }

    private void OnMouseOver()
    {
        Debug.Log("Entra");
    }
}
