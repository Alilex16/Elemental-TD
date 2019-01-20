using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AffinityBar : MonoBehaviour { //, IPointerEnterHandler, IPointerExitHandler

	public Text earthAffinityText;
	public Text fireAffinityText;
	public Text waterAffinityText;

	[Header("Unity Stuff")]
	public Image earthAffinityBar; //favor
	public Image fireAffinityBar;
	public Image waterAffinityBar;


	// Update is called once per frame
	void Update ()
	{
		earthAffinityText.text = "Earth Favor: " + PlayerStats.earthFavorTotal.ToString("0") + " "; //Add Earth favor Icon
		fireAffinityText.text = "Fire Favor: " + PlayerStats.fireFavorTotal.ToString("0") + " "; //Add Fire favor Icon
		waterAffinityText.text = "Water Favor: " + PlayerStats.waterFavorTotal.ToString("0") + " "; //Add Water favor Icon

		earthAffinityBar.fillAmount = PlayerStats.earthFavorTotal / PlayerStats.favorMax;
		fireAffinityBar.fillAmount = PlayerStats.fireFavorTotal / PlayerStats.favorMax;
		waterAffinityBar.fillAmount = PlayerStats.waterFavorTotal / PlayerStats.favorMax;


	}

//	public void OnPointerEnter (PointerEventData eventData){}

//	public void OnPointerExit (PointerEventData eventdata){}


	//GameObject effect = (GameObject)Instantiate (hoverText, GetBuildPosition (), Quaternion.identity);


}
