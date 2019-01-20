using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	[Header("Starting Affinity")]
	public static float earthAffinity;
	public static float fireAffinity;
	public static float waterAffinity;
    public static float earthFavorTotal;
    public static float fireFavorTotal;
    public static float waterFavorTotal;

    public static float earthFavorPerTurret = 1; // 1 + RP.Upgrade
    public static float fireFavorPerTurret = 1;
    public static float waterFavorPerTurret = 1;

    public static int favorMax = 300;
    
    //public int startAffinity = 0;

    //public float totalRPGained = 0; // shown @ headquarters
    public static float worthRP; //RP gained per kill. totalRPGained.
    //public static float divinityTokenTotal;
    public static float score;

    [Header("Starting Gems")]
    public static int gemsEarthAmount;
    public static int gemsFireAmount;
    public static int gemsWaterAmount;

    [Header("Advanced Gems")]
    public static int gemsMetalAmount;
    public static int gemsLightningAmount;
    public static int gemsIceAmount;
    public static int gemsLavaAmount;
    public static int gemsSteamAmount;
    public static int gemsMudAmount;

    //public static int gemsEarthStart;
    //public static int gemsFireStart;
    //public static int gemsWaterStart;
    

    public int startingTurrets = 1;
    public static int totalTurrets; //amount of turrets allowed to build
    

    public static int Lives;
    public static int startLivesRecord;
	public int startLives = 20; //min.10 , max.20

	public static int Rounds;

    //public static int highScore; //rounds survived/lives left/monsters killed/RP gathered/favor gained


	// Use this for initialization
	void Start () 
	{
		earthAffinity = 0;
		fireAffinity = 0;
		waterAffinity = 0;

		Lives = startLives;
        startLivesRecord = startLives;
        totalTurrets = startingTurrets;

        gemsEarthAmount = HeadquarterManager.gemsEarthAmountStarting + 5; //remove + 5; only used for testing
        gemsFireAmount = HeadquarterManager.gemsFireAmountStarting + 5; //remove + 5; only used for testing
        gemsWaterAmount = HeadquarterManager.gemsWaterAmountStarting + 5; //remove + 5; only used for testing
        Rounds = 0;

        //gemsEarthStart = gemsEarthAmountStarting;
        //gemsFireStart = gemsFireAmountStarting;
        //gemsWaterStart = gemsWaterAmountStarting;

        //if below is not present, when restarting you keep the infused gems from last game
        gemsMetalAmount = 0;
        gemsLightningAmount = 0;
        gemsIceAmount = 0;
        gemsLavaAmount = 0;
        gemsSteamAmount = 0;
        gemsMudAmount = 0;

        earthFavorTotal = 0;
        fireFavorTotal = 0;
        waterFavorTotal = 0;

        worthRP = 0;
    }

    private void Update()
    {
        if (GameManager.gameIsOver == false)
        {
            if (earthFavorTotal <= favorMax)
            {
                earthFavorTotal += earthAffinity * (0.02f * Time.timeScale);
            }
            if (fireFavorTotal <= favorMax)
            {
                fireFavorTotal += fireAffinity * (0.02f * Time.timeScale);
            }
            if (waterFavorTotal <= favorMax)
            {
                waterFavorTotal += waterAffinity * (0.02f * Time.timeScale);
            }
        }

        //if game != over
        //Debug.Log("Favor: " + earthAffinity);
        //Debug.Log("Total Favor: " + earthFavorTotal);
    }
}
