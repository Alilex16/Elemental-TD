using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResearchManager : MonoBehaviour {


    //SKilNumbers need to be saved/shown/stored here, not in ResearchSkillRequirements!!!!!!!



    [SerializeField]
    private int activeTab = 0; //use this for what exactly??

    public GameObject favorTab;
    public GameObject researchTab;
    public GameObject towerTab;
    public GameObject livesTab;
    public GameObject extraTab;

    public GameObject allSkills01;
    public GameObject allSkills02;
    public GameObject allSkills03;
    public GameObject allSkills04;
    public GameObject allSkills05;




    public void TabActive()
    {
        DeactivateRestSkills();

        if (favorTab.GetComponent<CanvasGroup>().alpha == 1)
        {
            allSkills01.SetActive (true);
            activeTab = 0;
        }
        if (researchTab.GetComponent<CanvasGroup>().alpha == 1)
        {
            allSkills02.SetActive(true);
            activeTab = 1;
        }
        if (towerTab.GetComponent<CanvasGroup>().alpha == 1)
        {
            allSkills03.SetActive(true);
            activeTab = 2;
        }
        if (livesTab.GetComponent<CanvasGroup>().alpha == 1)
        {
            allSkills04.SetActive(true);
            activeTab = 3;
        }
        if (extraTab.GetComponent<CanvasGroup>().alpha == 1)
        {
            allSkills05.SetActive(true);
            activeTab = 4;
        }

        CanvasGroupChanged();
    }

    public void DeactivateRestSkills()
    {
        allSkills01.SetActive(false);
        allSkills02.SetActive(false);
        allSkills03.SetActive(false);
        allSkills04.SetActive(false);
        allSkills05.SetActive(false);
    }


    public void CanvasGroupChanged() //removes all tooltips when changing tabs
    {
        FindObjectOfType<ResearchSkillRequirements>().ResetText();
        //FindObjectOfType<ResearchSkillUpgrade>().ResetText();
    }
}
