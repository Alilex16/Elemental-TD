using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleTraitsRP : MonoBehaviour {

    [Header("Toggles")]
    public GameObject rpMod120;
    public GameObject rpMod115;
    public GameObject rpMod110;
    public GameObject rpMod100;
    public GameObject rpMod90;
    public GameObject rpMod85;
    public GameObject rpMod80;

    public static int rpTrait01; // devide by
    public static int rpTrait02; // multiply by

    public void RPointsModifier() //happens twice when clicking a new value. Issue?
    {
        UpdateValueChanged(); //calls this function when changed, aka when pressed.
        //Debug.Log("Value Changed");
    }

    public void UpdateValueChanged()
    {
        if (rpMod120.GetComponent<Toggle>().isOn == true)
        {
            rpTrait01 = 5;
            rpTrait02 = 6;
            //Debug.Log("Amount of Research points gained: " + "+20%");
        }
        if (rpMod115.GetComponent<Toggle>().isOn == true)
        {
            rpTrait01 = 20;
            rpTrait02 = 23;
        }
        if (rpMod110.GetComponent<Toggle>().isOn == true)
        {
            rpTrait01 = 10;
            rpTrait02 = 11;
        }
        if (rpMod100.GetComponent<Toggle>().isOn == true) // base value
        {
            rpTrait01 = 1;
            rpTrait02 = 1;
        }
        if (rpMod90.GetComponent<Toggle>().isOn == true)
        {
            rpTrait01 = 10;
            rpTrait02 = 9;
        }
        if (rpMod85.GetComponent<Toggle>().isOn == true)
        {
            rpTrait01 = 20;
            rpTrait02 = 17;
        }
        if (rpMod80.GetComponent<Toggle>().isOn == true)
        {
            rpTrait01 = 5;
            rpTrait02 = 4;
        }
    }
}
