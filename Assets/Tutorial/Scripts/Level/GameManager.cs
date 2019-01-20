using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static bool gameIsOver; // static carries over to next scene

    public static float divinityGain; //int?
    public static float totalRPGained;

    public static float rating;
    
    public GameObject gameOverUI;
	public GameObject completeLevelUI;

//	public string nextLevel = "Level02";
//	public int levelToUnlock = 2;

//	public SceneFader sceneFader;


	// Use this for initialization
	void Start ()
	{
		gameIsOver = false;
		//Application.LoadLevelAdditive("MainScene"); // loads the UI
	}
	
	// Update is called once per frame
	void Update ()
	{

        if (PlayerStats.Lives <= 0) //was below (gameIsOver)
        {
            EndGame();
        }

        if (gameIsOver)
            GameSpeed.speed = 1f;


        return;

		//TEST CODE
		//if (Input.GetKeyDown ("e"))
		//{
		//	EndGame ();
		//}
        
	}

	void EndGame ()
	{
        //Debug.Log ("Game over!");

        ResearchPoints();

        gameIsOver = true;

        gameOverUI.SetActive (true);

	}


	public void WinLevel ()
	{
        //		Debug.Log ("Level won");
        //		PlayerPrefs.SetInt ("levelReached", levelToUnlock);
        //		sceneFader.FadeTo (nextLevel);
        DivinityTokens();

        ResearchPoints();

        Rating(); ////

        gameIsOver = true;

		completeLevelUI.SetActive(true);
	}

    public void ResearchPoints()
    {
        totalRPGained = PlayerStats.worthRP;
        totalRPGained = Mathf.Floor(totalRPGained);
        HeadquarterManager.researchPointsCollection += totalRPGained;
    }

    public void DivinityTokens() //only gain DT when you finish a level
    {
        divinityGain = 0; //add Divinity Tokens
        divinityGain = ((PlayerStats.earthFavorTotal + PlayerStats.fireFavorTotal + PlayerStats.waterFavorTotal) / 100);
        //Debug.Log("DT gained Before: " + divinityGain);
        divinityGain = Mathf.Floor(divinityGain); //rounding it down
        HeadquarterManager.divinityTokenCollection += divinityGain;
        //Debug.Log("DT gained After: " + divinityGain);
        //Debug.Log("DT total: " + HeadquarterManager.divinityTokenCollection);
    }

    public void Rating() //after you win the level
    {
        if (PlayerStats.Lives >= 1)
        {
            float livesLeft = PlayerStats.Lives;
            float livesStart = PlayerStats.startLivesRecord;

            rating = ((livesLeft / livesStart) * 100f); // going from 5 to 100, increments of 5.

            //Debug.Log("Lives: " + livesLeft);
            //Debug.Log("startLivesRecord: " + livesStart);
            //Debug.Log("Rating: " + rating);

            //RatingGem.Instance.RatingStatic(); //doesn't work, because different scene???
        }

        //if (level=X) is played, said level call for function to update StaticRating. 

    }

}
