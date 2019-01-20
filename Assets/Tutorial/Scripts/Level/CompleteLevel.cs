using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //when loading new levels

public class CompleteLevel : MonoBehaviour {

	public string mainMenu = "MainMenu";

	public string nextLevel = "Level02";
	public int levelToUnlock = 2; //change this number in the inspector per level

	public SceneFader sceneFader;

    public static bool finishedLevelA;
    public static bool finishedLevelB;
    public static bool finishedLevelC;
    public static bool finishedLevelD;
    public static bool finishedLevelE;
    public static bool finishedLevelF;
    public static bool finishedLevelG;
    public static bool finishedLevelH;
    public static bool finishedLevelI;
    public static bool finishedLevelJ;


    public void Continue ()
	{
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // HANDY!
        //sceneFader.FadeTo(SceneManager.GetActiveScene().name);	
        LevelStatus();
        PlayerPrefs.SetInt ("levelReached", levelToUnlock);
		sceneFader.FadeTo (nextLevel);
	}


	public void Menu ()
	{
        LevelStatus();
        //Debug.Log ("Go to menu.");
        sceneFader.FadeTo(mainMenu);	
	}

    private void LevelStatus()
    {
        if (LevelStart.a == true)
        {
            finishedLevelA = true;
        }
        if (LevelStart.b == true)
        {
            finishedLevelB = true;
        }
        if (LevelStart.c == true)
        {
            finishedLevelC = true;
        }
        if (LevelStart.d == true)
        {
            finishedLevelD = true;
        }
        if (LevelStart.e == true)
        {
            finishedLevelE = true;
        }
        if (LevelStart.f == true)
        {
            finishedLevelF = true;
        }
        if (LevelStart.g == true)
        {
            finishedLevelG = true;
        }
        if (LevelStart.h == true)
        {
            finishedLevelH = true;
        }
        if (LevelStart.i == true)
        {
            finishedLevelI = true;
        }
        if (LevelStart.j == true)
        {
            finishedLevelJ = true;
        }

        ResetLevel();
    }

    private void ResetLevel()
    {
        LevelStart.a = false;
        LevelStart.b = false;
        LevelStart.c = false;
        LevelStart.d = false;
        LevelStart.e = false;
        LevelStart.f = false;
        LevelStart.g = false;
        LevelStart.h = false;
        LevelStart.i = false;
        LevelStart.j = false;
    }

}
