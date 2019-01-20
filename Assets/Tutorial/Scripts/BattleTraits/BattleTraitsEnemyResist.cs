using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleTraitsEnemyResist : MonoBehaviour {
    
    [Header("Toggles")]
    public GameObject enemiesResist80;
    public GameObject enemiesResist90;
    public GameObject enemiesResist95;
    public GameObject enemiesResist100;
    public GameObject enemiesResist105;
    public GameObject enemiesResist110;
    public GameObject enemiesResist120;

    public static float resistTrait01; // 
    
    public void ResistsOfEnemies() //happens twice when clicking a new value. Issue?
    {
        UpdateValueChanged(); //calls this function when changed, aka when pressed.
        //Debug.Log("Value Changed");
    }

    public void UpdateValueChanged()
    {
        if (enemiesResist80.GetComponent<Toggle>().isOn == true)
        {
            resistTrait01 = -20.0f;
            //Debug.Log("Resists Of Enemies " + "-20");
        }
        if (enemiesResist90.GetComponent<Toggle>().isOn == true)
        {
            resistTrait01 = -10.0f;
        }
        if (enemiesResist95.GetComponent<Toggle>().isOn == true)
        {
            resistTrait01 = -5.0f;
        }
        if (enemiesResist100.GetComponent<Toggle>().isOn == true)
        {
            resistTrait01 = 0.0f;
        }
        if (enemiesResist105.GetComponent<Toggle>().isOn == true)
        {
            resistTrait01 = 5.0f;
        }
        if (enemiesResist110.GetComponent<Toggle>().isOn == true)
        {
            resistTrait01 = 10.0f;
        }
        if (enemiesResist120.GetComponent<Toggle>().isOn == true)
        {
            resistTrait01 = 20.0f;
        }
    }

}
