using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSpeed : MonoBehaviour {
    
    //disable camera speed being affected by this

    public static float speed = 1f;

    public float lastSpeed; //remember last speed used. Use that speed when unpausing the game.

    public Slider Slider;


    //private void Start()
    //{ //start on pause?
        //Time.timeScale = 1.0f;
        //Time.fixedDeltaTime = 0.02f * Time.timeScale;
    //}

    void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
            PauseGameNew ();
		}

        if (Input.GetKeyDown (KeyCode.Alpha1))
        {
            Slider.value = 1f; //speed = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Slider.value = 2f; //speed = 2f;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Slider.value = 3f; //speed = 3f;
        }

        Time.timeScale = speed; // * 1f;
        
    }


    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void PauseGameNew()
    {

        if (speed != 0f)
        {
            lastSpeed = speed;

            speed = 0f;
            Slider.value = 0f;
        }
        else
        {
            Slider.value = lastSpeed; //speed = lastSpeed;
        }
        
    }


    public void PauseGame ()
	{
		//Time.fixedDeltaTime = 2f;
		Debug.Log("Game paused");
		if (Time.timeScale == 1.0f || Time.timeScale == 0.5f || Time.timeScale == 2.0f)
			Time.timeScale = 0.0f;
		else
			Time.timeScale = 1.0f;
		Time.fixedDeltaTime = 0.02f * Time.timeScale;
	}

	public void HalfSpeed ()
	{
		//Time.fixedDeltaTime = 0.5f;
		Debug.Log("Half Speed");

		if (Time.timeScale == 1.0f || Time.timeScale == 2.0f)
			Time.timeScale = 0.5f;
		else
			Time.timeScale = 1.0f;
		Time.fixedDeltaTime = 0.02f * Time.timeScale;
	}

	public void NormalSpeed ()
	{
		//Time.fixedDeltaTime = 1f;
		Debug.Log("Normal Speed");
		Time.timeScale = 1f;
	}

	public void DoubleSpeed ()
	{
		//Time.fixedDeltaTime = 2f;
		Debug.Log("Double Speed");
		if (Time.timeScale == 1.0f || Time.timeScale == 0.5f)
			Time.timeScale = 2.0f;
		else
			Time.timeScale = 1.0f;
		Time.fixedDeltaTime = 0.02f * Time.timeScale;
	}


}
