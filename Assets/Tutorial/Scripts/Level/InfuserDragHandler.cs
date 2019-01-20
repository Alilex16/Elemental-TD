using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InfuserDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler{

    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;

    public GameObject parentGems; //place to return after clicking
    InfuserResult infuserResult;

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().alpha = 0.7f;
        GetComponent<CanvasGroup>().blocksRaycasts = false; //blocks raycasts
    }



    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }



    public void OnEndDrag(PointerEventData eventData)
    {

        itemBeingDragged = null;
        GetComponent<CanvasGroup>().alpha = 1f;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == startParent)
        {
            transform.position = startPosition;
        }
        //transform.position = startPosition;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (transform.parent.Find("GemEarthItem"))
        {
            //PlayerStats.gemsEarthAmount += 1;
        }
        if (transform.parent.Find("GemFireItem"))
        {
            //PlayerStats.gemsFireAmount += 1;
        }
        if (transform.parent.Find("GemWaterItem"))
        {
            //PlayerStats.gemsWaterAmount += 1;
        }
        
        transform.SetParent(parentGems.transform, false); //Fix the return position to be Fully Stretched
        transform.localRotation = Quaternion.identity;
        transform.localScale = Vector3.one;
        transform.localPosition = Vector3.zero;

        //infuserResult.ResetParentGems();
        InfuserResult.ResetInfuserSlots();
        //this.transform.parent = objectEarth.transform;
    }



    //point on click, destroy. if "earthgem" playerstats.earth+1

    //public void OnPointerClick(PointerEventData eventData)
    // {
    //     if (hasBeenDragged == true)
    //     {
    //         InfuserResult.ResetInfuserSlots();
    //         Debug.Log("Dragged");
    //         Transform.Destroy(gameObject);
    //         Destroy(this.gameObject);
    //     }
    //  }





}