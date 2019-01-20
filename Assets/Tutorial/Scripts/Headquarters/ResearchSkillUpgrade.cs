using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ResearchSkillUpgrade : MonoBehaviour, IPointerClickHandler{
    
    //public GameObject subjectsObject; //to search in the children. REMOVE?

    //public SkillUpgrade[] skillUpgrade;

    //public GameObject SkillButton01;
    //public GameObject SkillButton02;


    public void Awake()
    {
        //gm = gameObject.GetComponent<ResearchSkillRequirements>();
        //gm = GetComponent<ResearchSkillRequirements>();
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (GetComponentInParent<ResearchSkillRequirements>().transform.childCount == 4)
        {
            GetComponentInParent<ResearchSkillRequirements>().UpgradeSkill();// if using the transform, to children function
        }


        //if (ResearchSkillRequirements.skillNumberStatic == 1)
        //if (GetComponentInParent<ResearchSkillRequirements>().name == SkillButton01.name)
        //{
            //Debug.Log("Skill 01 clicked");
            
           // Debug.Log("Number of children: " + transform.childCount);

            //subjectsObject.GetComponentInChildren<ResearchSkillRequirements>().UpgradeSkill();

            //GetComponentInParent<ResearchSkillRequirements>().UpgradeSkill();// if using the transform, to children function

            //GetComponent<ResearchSkillRequirements>().LevelUpSkill();


            //gm.LevelUpSkill();
            //ResearchSkillRequirements.LevelUpSkill();
        //}

        //if (ResearchSkillRequirements.skillNumberStatic == 2)
       // {
          //  Debug.Log("Skill 02 clicked");


        //    Debug.Log("Number of children: " + transform.childCount);

          // GetComponentInParent<ResearchSkillRequirements>().UpgradeSkill();// if using the transform, to children function

            //subjectsObject.GetComponentInChildren<ResearchSkillRequirements>().UpgradeSkill();
        //}
    }
}