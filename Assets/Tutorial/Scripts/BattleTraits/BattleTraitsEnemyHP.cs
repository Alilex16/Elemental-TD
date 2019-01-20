using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleTraitsEnemyHP : MonoBehaviour {

    [Header("Toggles")]
    public GameObject enemiesHP50;
    public GameObject enemiesHP75;
    public GameObject enemiesHP100;
    public GameObject enemiesHP125;
    public GameObject enemiesHP150;
    public GameObject enemiesHP200;
    public GameObject enemiesHP300;

    public static float healthTrait01 = 1.0f; // 


    public void HPOfEnemies() //happens twice when clicking a new value. Issue?
    {
        UpdateValueChanged(); //calls this function when changed, aka when pressed.
        //Debug.Log("Value Changed");
    }

    public void UpdateValueChanged()
    {
        if (enemiesHP50.GetComponent<Toggle>().isOn == true)
        {
            healthTrait01 = 0.5f;
            //Debug.Log("HP Of Enemies " + "50%");
        }
        if (enemiesHP75.GetComponent<Toggle>().isOn == true)
        {
            healthTrait01 = 0.75f;
        }
        if (enemiesHP100.GetComponent<Toggle>().isOn == true)
        {
            healthTrait01 = 1.0f;
        }
        if (enemiesHP125.GetComponent<Toggle>().isOn == true)
        {
            healthTrait01 = 1.25f;
        }
        if (enemiesHP150.GetComponent<Toggle>().isOn == true)
        {
            healthTrait01 = 1.5f;
        }
        if (enemiesHP200.GetComponent<Toggle>().isOn == true)
        {
            healthTrait01 = 2.0f;
        }
        if (enemiesHP300.GetComponent<Toggle>().isOn == true)
        {
            healthTrait01 = 3.0f;
        }
    }
}
