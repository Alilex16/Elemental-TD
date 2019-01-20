using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class InfuserSlotLeft : MonoBehaviour, IDropHandler {

    //public GameObject gemLeftImage;
    //public GameObject earthItem; // GemEarthItem
    public static bool hasEarthGemLeft;
    public static bool hasFireGemLeft;
    public static bool hasWaterGemLeft;
    
    public GameObject Item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    //public void OnDrop(PointerEventData eventData)
    //{
    //    if (!Item)  //if target with this script attached doesn't have an item, it will take the item that's dropped on it
    //    {
    //        InfuserDragHandler.itemBeingDragged.transform.SetParent(transform);
    //    }
    //}

    public void OnDrop(PointerEventData eventData)
    {
        if (!Item)  //if target with this script attached doesn't have an item, it will take the item that's dropped on it
        {
            InfuserDragHandler.itemBeingDragged.transform.SetParent(transform);
        }
    }

    public void Update()
    {
        //if (gemLeftImage.name.Contains("GemEarthItem")) // FINISH THIS SHIT!!
        //if (gemLeftImage.transform.FindChild("GemEarthItem"))
        //if (gemLeftImage.transform.Find("GemEarthItem") && hasEarthGemLeft == false)

        if (this.transform.Find("GemEarthItem") && hasEarthGemLeft == false) // && PlayerStats.gemsEarthAmount >= 1)
        {
            Debug.Log("Gem Slotted1");
            hasEarthGemLeft = true;
            //PlayerStats.gemsEarthAmount -= 1;
        }
        if (this.transform.Find("GemFireItem") && hasFireGemLeft == false) // && PlayerStats.gemsFireAmount >= 1)
        {
            Debug.Log("Gem Slotted2");
            hasFireGemLeft = true;
            //PlayerStats.gemsFireAmount -= 1;
        }
        if (this.transform.Find("GemWaterItem") && hasWaterGemLeft == false) // && PlayerStats.gemsWaterAmount >= 1)
        {
            Debug.Log("Gem Slotted3");
            hasWaterGemLeft = true;
            //PlayerStats.gemsWaterAmount -= 1;
        }
    }
}