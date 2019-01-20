using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GainedDT : MonoBehaviour {

	public Text DTText;

	void OnEnable () // every time the object gets enabled
	{
		StartCoroutine (Blurp ());
	}

	IEnumerator Blurp()
	{
		DTText.text = "0";
		int dt = 0;

		yield return new WaitForSeconds (0.07f); //0.7f

		while (dt < GameManager.divinityGain)
		{
			dt++;
			DTText.text = dt.ToString ();

			yield return new WaitForSeconds (0.005f); //0.05f
		}


	}


}
