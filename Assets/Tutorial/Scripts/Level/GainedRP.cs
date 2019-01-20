using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GainedRP : MonoBehaviour {

	public Text RPText;

	void OnEnable () // every time the object gets enabled
	{
		StartCoroutine (AnimateText ());
	}

	IEnumerator AnimateText ()
	{
		RPText.text = "0";
		int rp = 0;

		yield return new WaitForSeconds (0.07f); //0.7f

		while (rp < PlayerStats.worthRP)
		{
			rp++;
			RPText.text = rp.ToString ();

			yield return new WaitForSeconds (0.005f); //0.05f
		}


	}


}
