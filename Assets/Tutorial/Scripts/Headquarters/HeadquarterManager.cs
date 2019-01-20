using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadquarterManager : MonoBehaviour{

    [Header("Gem UI")]
    public Text earthGemCollectionText;
    public Text fireGemCollectionText;
    public Text waterGemCollectionText;

    [Header("DT UI")]
    public Text divinityTokenCollectionText;

    [Header("RP UI")]
    public Text researchPointsCollectionText;

    [Header("Gem Collection")]
    public static int gemsEarthAmountStarting;
    public static int gemsFireAmountStarting;
    public static int gemsWaterAmountStarting;

    [Header("DT Collection")]
    public static float divinityTokenCollection;
    public static float researchPointsCollection;

    public float divinityTokenBonus = 500;// TEMP
    public float researchPointsTokenBonus = 5000;// TEMP



    private void Start()
    {
        divinityTokenCollection += divinityTokenBonus; // TEMP
        researchPointsCollection += researchPointsTokenBonus;// TEMP
        gemsEarthAmountStarting = 3; //lower this to 1. Make this "1" a variable that can be increased by Research.
        gemsFireAmountStarting = 3; //lower this to 1
        gemsWaterAmountStarting = 3; //lower this to 1
    }

    void Update()
    {
        earthGemCollectionText.text = gemsEarthAmountStarting.ToString();
        fireGemCollectionText.text = gemsEarthAmountStarting.ToString();
        waterGemCollectionText.text = gemsEarthAmountStarting.ToString();
        divinityTokenCollectionText.text = divinityTokenCollection.ToString("0");
        researchPointsCollectionText.text = researchPointsCollection.ToString("0");
        
    }
    
}
