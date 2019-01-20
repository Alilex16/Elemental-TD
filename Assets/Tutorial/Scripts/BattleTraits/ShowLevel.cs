using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowLevel : MonoBehaviour { //rename this to Manager

    public SceneFader fader;

    public Text showLevelText;
    public Text showDifficultyText;


    // Use this for initialization
    void Start ()
    {
        if (LevelStart.a == true)
        {
            showLevelText.text = 1.ToString("00");
        }
        if (LevelStart.b == true)
        {
            showLevelText.text = 2.ToString("00");
        }
        if (LevelStart.c == true)
        {
            showLevelText.text = 3.ToString("00");
        }
        if (LevelStart.d == true)
        {
            showLevelText.text = 4.ToString("00");
        }
        if (LevelStart.e == true)
        {
            showLevelText.text = 5.ToString("00");
        }
        if (LevelStart.f == true)
        {
            showLevelText.text = 6.ToString("00");
        }
        if (LevelStart.g == true)
        {
            showLevelText.text = 7.ToString("00");
        }
        if (LevelStart.h == true)
        {
            showLevelText.text = 8.ToString("00");
        }
        if (LevelStart.i == true)
        {
            showLevelText.text = 9.ToString("00");
        }
        if (LevelStart.j == true)
        {
            showLevelText.text = 10.ToString("00");
        }

        //if (RatingManager.normalBool == false && RatingManager.hardBool == false && RatingManager.impossibleBool == false)
        //{
        //    showDifficultyText.text = "Easy";
        //}
        //if (RatingManager.normalBool == true)
        //{
        //    showDifficultyText.text = "Normal";
        //}
        //if (RatingManager.hardBool == true)
        //{
        //    showDifficultyText.text = "Hard";
        //}
        //if (RatingManager.impossibleBool == true)
        //{
        //    showDifficultyText.text = "Impossible";
        //}

    }
	
    public void Select(string levelName)
    {
        fader.FadeTo(levelName);
    }

}
