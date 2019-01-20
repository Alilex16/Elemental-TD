using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RatingManager : MonoBehaviour {

    //public GameObject difficultySetting;
    
    public GameObject rating01Level01;
    //public GameObject rating02Level01;
    //public GameObject rating03Level01;
    //public GameObject rating04Level01;
    public GameObject rating01Level02;
    public GameObject rating01Level03;
    private float thisRating;

    //public static int difficulty;
    
    //public static bool normalBool;
    //public static bool hardBool;
    //public static bool impossibleBool;
    
    // Use this for initialization
    void Start ()
    {
        //difficulty = difficultySetting.GetComponent<Dropdown>().value;

        thisRating = GameManager.rating / 100;
        
        //difficultySetting.GetComponent<Dropdown>().value = xTest;
        
        if (LevelStart.levelNumberStatic == 1) //&& difficulty != 1 && difficulty != 2 && difficulty != 3) //first level "1", difficulty easy
        {
            rating01Level01.GetComponent<Image>().fillAmount = thisRating;
            Debug.Log("Level 1");
        }
        if (LevelStart.levelNumberStatic == 2) //&& difficulty != 1 && difficulty != 2 && difficulty != 3) //first level "1", difficulty easy
        {
            rating01Level02.GetComponent<Image>().fillAmount = thisRating;
            Debug.Log("Level 2");
        }
    }
	

    //public void SetDifficulty()
    //{
    //    difficulty = difficultySetting.GetComponent<Dropdown>().value;
    //}
    
    /// <summary>
    /// FIX THIS SHIT
    /// </summary>

    //public void DifficultyChange()
    //{
        //SetDifficulty();

        //PlayerPrefs.SetInt("difficulty", difficulty);

        //ResetBools();
        
        //if (difficulty == 1)
        //{
            //PlayerPrefs.SetInt("difficulty", 1);
        //    normalBool = true;
        //}
        //if (difficulty == 2)
        //{
            //PlayerPrefs.SetInt("difficulty", 2);
        //    hardBool = true;
        //}
        //if (difficulty == 3)
        //{
            //PlayerPrefs.SetInt("difficulty", 3);
        //    impossibleBool = true;
        //}
   // }


	// Update is called once per frame
	void Update ()
    {
        //difficulty = difficultySetting.GetComponent<Dropdown>().value;

        //if (LevelStart.levelNumberStatic == 1) //first level "1"
        // {
        //Debug.Log("Static = 1." + thisRating);
        //rating01Level01.GetComponent<Image>().fillAmount = thisRating;
        //}
        // if (LevelStart.a == true) //first level "1"
        // {
        //      Debug.Log("a = true." + thisRating);
        //     rating01Level01.GetComponent<Image>().fillAmount = thisRating;
        //  }


        //if (difficultySetting.GetComponent<Dropdown>().value == 0) // easy
        //{
        //    Debug.Log("Easy.");
        //GetComponent<CanvasGroup>().alpha
        //}
    }
}
