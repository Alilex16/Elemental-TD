using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public GameObject ui;

	public SceneFader sceneFader;
	public string mainMenu = "MainMenu";

    //GameSpeed gameSpeed;

    void Update ()
	{
        //if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown (KeyCode.P))
        if (Input.GetKeyDown(KeyCode.P))
        {
			Toggle ();
		}
	}

	public void Toggle ()
	{
		ui.SetActive (!ui.activeSelf);

		if (ui.activeSelf)
		{
            //gameSpeed.speed = 0f;
            //gameSpeed.Slider.value = 0f;
            Time.timeScale = 0f;
            //use Time.fixedDeltaTime - when slowing down or speeding up the game
        }
        else
		{
            ///gameSpeed.speed = 1f;
            //gameSpeed.Slider.value = 1f; //gameSpeed.lastSpeed;
            Time.timeScale = 1f;
        }

	}

	public void Retry ()
	{
		Toggle ();
		//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		sceneFader.FadeTo(SceneManager.GetActiveScene().name);
	}

	public void Menu ()
	{
		//Debug.Log ("Go to menu.");
		//SceneManager.LoadScene (mainMenu);
		Toggle ();
		sceneFader.FadeTo(mainMenu);
	}



}
