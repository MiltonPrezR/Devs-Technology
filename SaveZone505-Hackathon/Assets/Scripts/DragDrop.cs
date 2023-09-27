using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler,IPointerEnterHandler, IPointerExitHandler
{
    public static GameObject itemDragging;
    
    private Vector3 startPosition;
    private Transform startParent;
    private Transform dragParent;
    private GameObject Mochila;
    public static Animator MochilaAnimator;
    public bool respuesta;
    
    public void OnBeginDrag(PointerEventData point)
    {
        itemDragging = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(dragParent);
        MochilaAnimator.SetInteger("Pasar", 2);
        
    }

    public void OnDrag(PointerEventData point)
    {
        transform.position = Input.mousePosition;
        MochilaAnimator.SetInteger("Pasar", 3);
        //if ()
    }
    
    public void OnEndDrag(PointerEventData point)
    {
        itemDragging = null;
        if (transform.parent == dragParent)
        {
            transform.position = startPosition;
            transform.SetParent(startParent);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
        Mochila = GameObject.FindGameObjectWithTag("Mochila");
        MochilaAnimator = Mochila.GetComponent<Animator>();
    }

    //Entra y sale del objeto
    public void OnPointerEnter(PointerEventData eventData)
    {
        MochilaAnimator.SetInteger("Pasar", 1);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        MochilaAnimator.SetInteger("Pasar", 0);
    }
}
