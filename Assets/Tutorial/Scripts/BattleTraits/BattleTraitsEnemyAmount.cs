using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleTraitsEnemyAmount : MonoBehaviour{

    [Header("Toggles")]
    //public bool amountOfEnemies;
    public GameObject enemiesAmount50;
    public GameObject enemiesAmount75;
    public GameObject enemiesAmount100;
    public GameObject enemiesAmount125;
    public GameObject enemiesAmount150;
    public GameObject enemiesAmount200;
    public GameObject enemiesAmount300;
    
    //Math Stuff:
    public static int amountTrait01 = 1; // devide by
    public static int amountTrait02 = 1; // multiply by

    public void AmountOfEnemies() //happens twice when clicking a new value. Issue?
    {
        UpdateValueChanged(); //calls this function when changed, aka when pressed.
        //Debug.Log("Value Changed");
    }

    public void UpdateValueChanged()
    {
        if (enemiesAmount50.GetComponent<Toggle>().isOn == true)
        {
            amountTrait01 = 2;
            amountTrait02 = 1;
            //Debug.Log("Amount Of Enemies " + "50%");
        }
        if (enemiesAmount75.GetComponent<Toggle>().isOn == true)
        {
            amountTrait01 = 4;
            amountTrait02 = 3;
        }
        if (enemiesAmount100.GetComponent<Toggle>().isOn == true)
        {
            amountTrait01 = 1;
            amountTrait02 = 1;
        }
        if (enemiesAmount125.GetComponent<Toggle>().isOn == true)
        {
            amountTrait01 = 4;
            amountTrait02 = 5;
        }
        if (enemiesAmount150.GetComponent<Toggle>().isOn == true)
        {
            amountTrait01 = 2;
            amountTrait02 = 3;
        }
        if (enemiesAmount200.GetComponent<Toggle>().isOn == true)
        {
            amountTrait01 = 1;
            amountTrait02 = 2;
        }
        if (enemiesAmount300.GetComponent<Toggle>().isOn == true)
        {
            amountTrait01 = 1;
            amountTrait02 = 3;
        }
    }






}
