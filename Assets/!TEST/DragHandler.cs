using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false; //blocks raycasts
    }



    public void OnDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        transform.position = Input.mousePosition;

    }



    public void OnEndDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        itemBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true; //blocks raycasts
        if (transform.parent == startParent)
        {
            transform.position = startPosition;
        }
        
    }


}