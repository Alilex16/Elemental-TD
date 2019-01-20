//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour {

    public SceneFader fader;

    //public static int levelPlayed; ////

    public Button[] levelButtons;


    void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++) //for tab tab
        {
            if (i + 1 > levelReached)
                levelButtons[i].interactable = false;
            //levelPlayed = i;
        }
    }

    public void Select(string levelName)
    {
        fader.FadeTo(levelName);
    }


    //public void LevelPlayed(int levelPlayed) // REMOVE THIS
    //{
    ////Assign the level buttons an integer
    //}

}



