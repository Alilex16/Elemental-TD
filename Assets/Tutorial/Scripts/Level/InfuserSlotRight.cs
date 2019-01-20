using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class InfuserSlotRight : MonoBehaviour, IDropHandler {

    //public GameObject gemRightImage;
    //public GameObject earthItem; // GemEarthItem
    public static bool hasEarthGemRight;
    public static bool hasFireGemRight;
    public static bool hasWaterGemRight;
        
    public GameObject Item
    {
        get
        {
            if (transform.childCount > 0)
            {
                // transform.GetChild (0);
                return transform.GetChild(0).gameObject;
            }
            //if (GameObject.Find("InsertGemLeft"))
            //{
            //    return transform.GetChild(0).gameObject;
            //}

            return null;
        }
    }


    public void OnDrop(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        if (!Item)  //isDragged == false //if target with this script attached doesn't have an item, it will take the item that's dropped on it
        {
            //Debug.Log("Gem Slotted");
            InfuserDragHandler.itemBeingDragged.transform.SetParent(transform);
            //ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject,null,(x, y) => x.HasChanged());
        }
    }

    public void Update()
    {
        //if (gemRightImage.name.Contains("GemEarthItem")) // FINISH THIS SHIT!!
        //if (gemRightImage.transform.FindChild("GemEarthItem"))
        //if (gemRightImage.transform.Find("GemEarthItem") && hasEarthGemRight == false)
        if (this.transform.Find("GemEarthItem") && hasEarthGemRight == false && PlayerStats.gemsEarthAmount >= 1)
        {
            Debug.Log("Gem Slotted1");
            hasEarthGemRight = true;
            //PlayerStats.gemsEarthAmount -= 1;
        }
        if (this.transform.Find("GemFireItem") && hasFireGemRight == false && PlayerStats.gemsFireAmount >= 1)
        {
            Debug.Log("Gem Slotted2");
            hasFireGemRight = true;
            //PlayerStats.gemsFireAmount -= 1;
        }
        if (this.transform.Find("GemWaterItem") && hasWaterGemRight == false && PlayerStats.gemsWaterAmount >= 1)
        {
            Debug.Log("Gem Slotted3");
            hasWaterGemRight = true;
            //PlayerStats.gemsWaterAmount -= 1;
        }
    }

    //

}