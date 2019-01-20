using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private bool doMovement = true;

	public float panSpeed = 30f;

	public float panBorderThickness = 10f;

	public float scrollSpeed = 5f;
	public float minY = 20f;
	public float maxy = 80f;

	
	// Update is called once per frame
	void Update ()
	{

		if (GameManager.gameIsOver)
		{
			this.enabled = false;
			return;
		}
			
		//if (Input.GetKeyDown (KeyCode.Space))
		//{
		//	Debug.Log ("Enemies left alive:" + WaveSpawner.EnemiesAlive);
		//}


		//Stops all camera movement
		if (Input.GetKeyDown (KeyCode.Q))
			doMovement = !doMovement;

		if (!doMovement)
			return;
		//
		

		if (Input.GetKey ("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
		{ //Space.World ignores the rotation of the camera
            if (transform.localPosition.z <= 60) //make it a variable
            {
                transform.Translate(Vector3.forward * panSpeed * 0.02f, Space.World); // 0.02f instead of Time.deltaTime
            }
            //else
            //{
                //Debug.Log("Cannot exceed this limit");
            //}
        }

		if (Input.GetKey ("s") || Input.mousePosition.y <= panBorderThickness)
		{ //Space.World ignores the rotation of the camera
            if (transform.localPosition.z >= -10) //make it a variable
            {
                transform.Translate(Vector3.back * panSpeed * 0.02f, Space.World);
            }
		}

		if (Input.GetKey ("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
		{ //Space.World ignores the rotation of the camera
            if (transform.localPosition.x <= 60) //make it a variable
            {
                transform.Translate(Vector3.right * panSpeed * 0.02f, Space.World);
            }
		}

		if (Input.GetKey ("a") || Input.mousePosition.x <= panBorderThickness)
		{ //Space.World ignores the rotation of the camera
            if (transform.localPosition.x >= 0) //make it a variable
            {
                transform.Translate(Vector3.left * panSpeed * 0.02f, Space.World);
            }
		}



		float scroll = Input.GetAxis ("Mouse ScrollWheel");

		Vector3 pos = transform.position;

        pos.y -= scroll * 1000 * scrollSpeed * 0.02f; // 0.02f OR Time.deltaTime;
		pos.y = Mathf.Clamp (pos.y, minY, maxy);

		transform.position = pos;

	}
}
