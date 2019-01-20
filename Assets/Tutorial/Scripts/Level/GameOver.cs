using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //when loading new levels

public class GameOver : MonoBehaviour {

	public string mainMenu = "MainMenu";

	public SceneFader sceneFader;

	public void Retry ()
	{
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // HANDY!
		sceneFader.FadeTo(SceneManager.GetActiveScene().name);	
	}


	public void Menu ()
	{
		//Debug.Log ("Go to menu.");
		sceneFader.FadeTo(mainMenu);	
	}

}
