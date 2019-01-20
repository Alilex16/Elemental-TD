using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour, IHasChanged {
    [SerializeField] Transform slots; //use this instead of public, unless you want access from other scripts
    [SerializeField] Text inventoryText;

    private void Start()
    {
        HasChanged();
    }


    public void HasChanged()
    {
        //throw new System.NotImplementedException();
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        builder.Append(" - ");

        foreach (Transform slotTransform in slots)
        {
            GameObject item = slotTransform.GetComponent<Slot>().Item;
            if (item)
            {
                builder.Append(item.name);
                builder.Append(" - ");
            }
        }
        inventoryText.text = builder.ToString();
    }
    





}


namespace UnityEngine.EventSystems
{
    public interface IHasChanged : IEventSystemHandler
    {
        void HasChanged();
    }
}