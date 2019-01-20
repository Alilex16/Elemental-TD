using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TraitRestrictions : MonoBehaviour {

    //public GameObject difficulty;
    //public GameObject dropDownList;
    public GameObject allTraits;

    //Dropdown m_Dropdown;

    private void Start()
    {
        if (LevelStart.a == true && CompleteLevel.finishedLevelA == false) //started first level, but not yet completed
        {
            allTraits.GetComponent<CanvasGroup>().interactable = false;
        }


        //GetComponentsInChildren<Transform>()
        //dropDownList.GetComponent<CanvasGroup>().alpha = 0;
        //m_Dropdown = GetComponent<Dropdown>();
        //m_Dropdown = GetComponent<Image>();

            //m_Dropdown.GetComponent<CanvasGroup>().alpha = 0;

            //if (CompleteLevel.finishedLevelA == false)
            //{
            //dropDownList.GetComponent<CanvasGroup>().alpha = 0;
            //difficulty.GetComponent<Dropdown>().value;

            //}
    }



}
