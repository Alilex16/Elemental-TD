using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Slot : MonoBehaviour, IDropHandler {

    public GameObject Item
    {
        get
        {
            if (transform.childCount > 0)
            {
                // transform.GetChild (0);
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }


    public void OnDrop(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        if (!Item)
        {
            DragHandler.itemBeingDragged.transform.SetParent(transform); //if it doesn't have an item, it will take the item that's dropped on it
            ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject,null,(x, y) => x.HasChanged());
        }
    }
}