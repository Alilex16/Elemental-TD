using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ResearchSkillRequirements : MonoBehaviour, IPointerClickHandler{
    
    public string subjectText;
    public string descriptionText;

    public Text tooltipSubjectText; //Headline
    public Text tooltipDescriptionText; //tooltip
    
    public GameObject upgradeButton;
    public static int skillLevel = 0;
    public Text upgradeText; //obsolete
    public Image upgradeImage;

    public Text upgradeCosts;
    public Text rpText;
    public Text dtText;

    public static float rpRequired;
    public static float dtRequired;

    public float rpLevel01 = 100;
    public float dtLevel01 = 2;

    private float rpLevel02;
    private float dtLevel02;

    private float rpLevel03;
    private float dtLevel03;

    private float rpLevel04;
    private float dtLevel04;

    private float rpLevel05;
    private float dtLevel05;

    private bool isUpgraded;


    //All skills...
    private int skillLevel01;
    private int skillLevel02;
    private int skillLevel03;
    private int skillLevel04;
    private int skillLevel05;
    private int skillLevel06;
    private int skillLevel07;
    private int skillLevel08;
    private int skillLevel09;
    private int skillLevel10;


    public static int skillNumberStatic;
    public int skillNumber; //set a unique number for each skill

    //[SerializeField]
    //private int showSkillNumber; // aka, static number
    
    public void Start()
    {
        upgradeImage.GetComponent<Image>().fillAmount = 0.0f;
        rpRequired = rpLevel01;
        //rpLevel01 = rpRequired;
        rpLevel02 = rpRequired * 2;
        rpLevel03 = rpRequired * 5;
        rpLevel04 = rpRequired * 15;
        rpLevel05 = rpRequired * 60;
        dtRequired = dtLevel01;
        //dtLevel01 = dtRequired;
        dtLevel02 = dtLevel01 * 2;
        dtLevel03 = dtLevel01 * 5;
        dtLevel04 = dtLevel01 * 15;
        dtLevel05 = dtLevel01 * 60;
    }



    public void OnPointerClick(PointerEventData eventData)
    {
        skillNumberStatic = skillNumber;
        //showSkillNumber = skillNumberStatic;
        
        upgradeCosts.text = "Costs: ";
        SkillUpdateTooltip();
        
        upgradeButton.transform.SetParent(transform); //sets the upgrade button a child of the selected skill
        
        tooltipSubjectText.text = subjectText; //"Description: ";
        tooltipDescriptionText.text = descriptionText; // "Each level increases Earth Favor gained by 10%.";
        
        if (skillNumber == skillNumberStatic)
        {
            //LevelUpSkill();
            //SkillUpdateTooltip();
        }
        else
        {
            Debug.Log("Not the same skill -- ERROR -- Should never occur");
            //Debug.Log("Not enough resources!");
        }

    }

    public void UpgradeSkill()
    {
        if (HeadquarterManager.researchPointsCollection >= rpRequired && HeadquarterManager.divinityTokenCollection >= dtRequired)
        {
            LevelUpSkill();
            //SkillUpdateTooltip();
        }
    }
    

    public void LevelUpSkill()
    {
        //if (HeadquarterManager.researchPointsCollection >= rpRequired && HeadquarterManager.divinityTokenCollection >= dtRequired)
        if (skillNumberStatic == 1) //if skill being upgraded is Earth Affinity
        {
            if (skillLevel01 == 0 && isUpgraded == false) //if Earth Affinity is level 0
            {
                LevelUpCosts01();
                Debug.Log("Earth Affinity Level up to Level 1");
            }
            if (skillLevel01 == 1 && isUpgraded == false)
            {
                LevelUpCosts02();
                Debug.Log("Earth Affinity Level up to Level 2");
            }
            if (skillLevel01 == 2 && isUpgraded == false)
            {
                LevelUpCosts03();
                Debug.Log("Earth Affinity Level up to Level 3");
            }
            if (skillLevel01 == 3 && isUpgraded == false)
            {
                LevelUpCosts04();
                Debug.Log("Earth Affinity Level up to Level 4");
            }
            if (skillLevel01 == 4 && isUpgraded == false)
            {
                LevelUpCosts05();
                Debug.Log("Earth Affinity Level up to Level 5");
            }

            if (skillLevel01 >= 4) //correct??
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 0;
                upgradeButton.GetComponent<CanvasGroup>().interactable = false;
            }

            if (skillLevel01 < 5)

            {
                skillLevel01 += 1;
                HeadquarterManager.researchPointsCollection -= rpRequired;
                HeadquarterManager.divinityTokenCollection -= dtRequired;
                upgradeImage.GetComponent<Image>().fillAmount += 0.2f;
                isUpgraded = false;
            }
        }
        
        if (skillNumberStatic == 2) //if skill being upgraded is Earth Affinity
        {
            if (skillLevel02 == 0 && isUpgraded == false)
            {
                LevelUpCosts01();
                Debug.Log("Fire Affinity Level up to Level 1");
            }
            if (skillLevel02 == 1 && isUpgraded == false)
            {
                LevelUpCosts02();
                Debug.Log("Fire Affinity Level up to Level 2");
            }
            if (skillLevel02 == 2 && isUpgraded == false) 
            {
                LevelUpCosts03();
                Debug.Log("Fire Affinity Level up to Level 3");
            }
            if (skillLevel02 == 3 && isUpgraded == false)
            {
                LevelUpCosts04();
                Debug.Log("Fire Affinity Level up to Level 4");
            }
            if (skillLevel02 == 4 && isUpgraded == false)
            {
                LevelUpCosts05();
                Debug.Log("Fire Affinity Level up to Level 5");
            }

            if (skillLevel02 >= 4) //correct??
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 0;
                upgradeButton.GetComponent<CanvasGroup>().interactable = false;
            }

            if (skillLevel02 < 5)

            {
                skillLevel02 += 1;
                HeadquarterManager.researchPointsCollection -= rpRequired;
                HeadquarterManager.divinityTokenCollection -= dtRequired;
                upgradeImage.GetComponent<Image>().fillAmount += 0.2f;
                isUpgraded = false;
            }

        }

        if (skillNumberStatic == 3) //if skill being upgraded is Water Affinity
        {
            if (skillLevel03 == 0 && isUpgraded == false)
            {
                LevelUpCosts01();
            }
            if (skillLevel03 == 1 && isUpgraded == false)
            {
                LevelUpCosts02();
            }
            if (skillLevel03 == 2 && isUpgraded == false)
            {
                LevelUpCosts03();
            }
            if (skillLevel03 == 3 && isUpgraded == false)
            {
                LevelUpCosts04();
            }
            if (skillLevel03 == 4 && isUpgraded == false)
            {
                LevelUpCosts05();
            }
            if (skillLevel03 >= 4)
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 0;
                upgradeButton.GetComponent<CanvasGroup>().interactable = false;
            }
            if (skillLevel03 < 5)
            {
                skillLevel03 += 1;
                HeadquarterManager.researchPointsCollection -= rpRequired;
                HeadquarterManager.divinityTokenCollection -= dtRequired;
                upgradeImage.GetComponent<Image>().fillAmount += 0.2f;
                isUpgraded = false;
            }
        }

        if (skillNumberStatic == 4) //if skill being upgraded is Water Affinity
        {
            if (skillLevel04 == 0 && isUpgraded == false)
            {
                LevelUpCosts01();
            }
            if (skillLevel04 == 1 && isUpgraded == false)
            {
                LevelUpCosts02();
            }
            if (skillLevel04 == 2 && isUpgraded == false)
            {
                LevelUpCosts03();
            }
            if (skillLevel04 == 3 && isUpgraded == false)
            {
                LevelUpCosts04();
            }
            if (skillLevel04 == 4 && isUpgraded == false)
            {
                LevelUpCosts05();
            }
            if (skillLevel04 >= 4)
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 0;
                upgradeButton.GetComponent<CanvasGroup>().interactable = false;
            }
            if (skillLevel04 < 5)
            {
                skillLevel04 += 1;
                HeadquarterManager.researchPointsCollection -= rpRequired;
                HeadquarterManager.divinityTokenCollection -= dtRequired;
                upgradeImage.GetComponent<Image>().fillAmount += 0.2f;
                isUpgraded = false;
            }
        }

        if (skillNumberStatic == 5) //if skill being upgraded is Water Affinity
        {
            if (skillLevel05 == 0 && isUpgraded == false)
            {
                LevelUpCosts01();
            }
            if (skillLevel05 == 1 && isUpgraded == false)
            {
                LevelUpCosts02();
            }
            if (skillLevel05 == 2 && isUpgraded == false)
            {
                LevelUpCosts03();
            }
            if (skillLevel05 == 3 && isUpgraded == false)
            {
                LevelUpCosts04();
            }
            if (skillLevel05 == 4 && isUpgraded == false)
            {
                LevelUpCosts05();
            }
            if (skillLevel05 >= 4)
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 0;
                upgradeButton.GetComponent<CanvasGroup>().interactable = false;
            }
            if (skillLevel05 < 5)
            {
                skillLevel05 += 1;
                HeadquarterManager.researchPointsCollection -= rpRequired;
                HeadquarterManager.divinityTokenCollection -= dtRequired;
                upgradeImage.GetComponent<Image>().fillAmount += 0.2f;
                isUpgraded = false;
            }
        }


    }
    
    public void LevelUpCosts01()
    {
        isUpgraded = true;
        rpRequired = rpLevel01;
        dtRequired = dtLevel01;
        rpText.text = rpLevel02.ToString() + " Research Points";
        dtText.text = dtLevel02.ToString() + " Divinity Tokens";
    }
    public void LevelUpCosts02()
    {
        rpRequired = rpLevel02;
        dtRequired = dtLevel02;
        rpText.text = rpLevel03.ToString() + " Research Points";
        dtText.text = dtLevel03.ToString() + " Divinity Tokens";
        isUpgraded = true;
    }
    public void LevelUpCosts03()
    {
        rpRequired = rpLevel03;
        dtRequired = dtLevel03;
        rpText.text = rpLevel04.ToString() + " Research Points";
        dtText.text = dtLevel04.ToString() + " Divinity Tokens";
        isUpgraded = true;
    }
    public void LevelUpCosts04()
    {
        rpRequired = rpLevel04;
        dtRequired = dtLevel04;
        rpText.text = rpLevel05.ToString() + " Research Points";
        dtText.text = dtLevel05.ToString() + " Divinity Tokens";
        isUpgraded = true;
    }
    public void LevelUpCosts05()
    {
        rpRequired = rpLevel05;
        dtRequired = dtLevel05;
        upgradeCosts.text = "No more upgrades!";
        rpText.text = "Maxed out.";
        dtText.text = "Cannot upgrade!";
        isUpgraded = true;
    }


    public void SkillUpdateTooltip()
    {
        if (skillNumberStatic == 1) //if skill being upgraded is Earth Affinity
        {
            if (skillLevel01 == 0) //if Earth Affinity is level 0
            {
                rpText.text = rpLevel01.ToString() + " Research Points";
                dtText.text = dtLevel01.ToString() + " Divinity Tokens";
            }
            if (skillLevel01 == 1)
            {
                rpText.text = rpLevel02.ToString() + " Research Points";
                dtText.text = dtLevel02.ToString() + " Divinity Tokens";
            }
            if (skillLevel01 == 2)
            {
                rpText.text = rpLevel03.ToString() + " Research Points";
                dtText.text = dtLevel03.ToString() + " Divinity Tokens";
            }
            if (skillLevel01 == 3)
            {
                rpText.text = rpLevel04.ToString() + " Research Points";
                dtText.text = dtLevel04.ToString() + " Divinity Tokens";
            }
            if (skillLevel01 == 4)
            {
                rpText.text = rpLevel05.ToString() + " Research Points";
                dtText.text = dtLevel05.ToString() + " Divinity Tokens";
            }

            if (skillLevel01 == 5)
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 0;
                upgradeButton.GetComponent<CanvasGroup>().interactable = false;
                upgradeCosts.text = "No more upgrades!";
                rpText.text = "Maxed out.";
                dtText.text = "Cannot upgrade!";
            }
            else
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 1;
                upgradeButton.GetComponent<CanvasGroup>().interactable = true;
            }
        }

        if (skillNumberStatic == 2) //if skill being upgraded is Fire Affinity
        {
            if (skillLevel02 == 0) //if Fire Affinity is level 0
            {
                rpText.text = rpLevel01.ToString() + " Research Points";
                dtText.text = dtLevel01.ToString() + " Divinity Tokens";
            }
            if (skillLevel02 == 1)
            {
                rpText.text = rpLevel02.ToString() + " Research Points";
                dtText.text = dtLevel02.ToString() + " Divinity Tokens";
            }
            if (skillLevel02 == 2)
            {
                rpText.text = rpLevel03.ToString() + " Research Points";
                dtText.text = dtLevel03.ToString() + " Divinity Tokens";
            }
            if (skillLevel02 == 3)
            {
                rpText.text = rpLevel04.ToString() + " Research Points";
                dtText.text = dtLevel04.ToString() + " Divinity Tokens";
            }
            if (skillLevel02 == 4)
            {
                rpText.text = rpLevel05.ToString() + " Research Points";
                dtText.text = dtLevel05.ToString() + " Divinity Tokens";
            }
            if (skillLevel02 == 5)
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 0;
                upgradeButton.GetComponent<CanvasGroup>().interactable = false;
                upgradeCosts.text = "No more upgrades!";
                rpText.text = "Maxed out.";
                dtText.text = "Cannot upgrade!";
            }
            else
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 1;
                upgradeButton.GetComponent<CanvasGroup>().interactable = true;
            }
        }

        if (skillNumberStatic == 3) //if skill being upgraded is Fire Affinity
        {
            if (skillLevel03 == 0) //if Fire Affinity is level 0
            {
                rpText.text = rpLevel01.ToString() + " Research Points";
                dtText.text = dtLevel01.ToString() + " Divinity Tokens";
            }
            if (skillLevel03 == 1)
            {
                rpText.text = rpLevel02.ToString() + " Research Points";
                dtText.text = dtLevel02.ToString() + " Divinity Tokens";
            }
            if (skillLevel03 == 2)
            {
                rpText.text = rpLevel03.ToString() + " Research Points";
                dtText.text = dtLevel03.ToString() + " Divinity Tokens";
            }
            if (skillLevel03 == 3)
            {
                rpText.text = rpLevel04.ToString() + " Research Points";
                dtText.text = dtLevel04.ToString() + " Divinity Tokens";
            }
            if (skillLevel03 == 4)
            {
                rpText.text = rpLevel05.ToString() + " Research Points";
                dtText.text = dtLevel05.ToString() + " Divinity Tokens";
            }
            if (skillLevel03 == 5)
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 0;
                upgradeButton.GetComponent<CanvasGroup>().interactable = false;
                upgradeCosts.text = "No more upgrades!";
                rpText.text = "Maxed out.";
                dtText.text = "Cannot upgrade!";
            }
            else
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 1;
                upgradeButton.GetComponent<CanvasGroup>().interactable = true;
            }
        }

        if (skillNumberStatic == 4) //if skill being upgraded is Fire Affinity
        {
            if (skillLevel04 == 0) //if Fire Affinity is level 0
            {
                rpText.text = rpLevel01.ToString() + " Research Points";
                dtText.text = dtLevel01.ToString() + " Divinity Tokens";
            }
            if (skillLevel04 == 1)
            {
                rpText.text = rpLevel02.ToString() + " Research Points";
                dtText.text = dtLevel02.ToString() + " Divinity Tokens";
            }
            if (skillLevel04 == 2)
            {
                rpText.text = rpLevel03.ToString() + " Research Points";
                dtText.text = dtLevel03.ToString() + " Divinity Tokens";
            }
            if (skillLevel04 == 3)
            {
                rpText.text = rpLevel04.ToString() + " Research Points";
                dtText.text = dtLevel04.ToString() + " Divinity Tokens";
            }
            if (skillLevel04 == 4)
            {
                rpText.text = rpLevel05.ToString() + " Research Points";
                dtText.text = dtLevel05.ToString() + " Divinity Tokens";
            }
            if (skillLevel04 == 5)
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 0;
                upgradeButton.GetComponent<CanvasGroup>().interactable = false;
                upgradeCosts.text = "No more upgrades!";
                rpText.text = "Maxed out.";
                dtText.text = "Cannot upgrade!";
            }
            else
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 1;
                upgradeButton.GetComponent<CanvasGroup>().interactable = true;
            }
        }

        if (skillNumberStatic == 5) //if skill being upgraded is Fire Affinity
        {
            if (skillLevel05 == 0) //if Fire Affinity is level 0
            {
                rpText.text = rpLevel01.ToString() + " Research Points";
                dtText.text = dtLevel01.ToString() + " Divinity Tokens";
            }
            if (skillLevel05 == 1)
            {
                rpText.text = rpLevel02.ToString() + " Research Points";
                dtText.text = dtLevel02.ToString() + " Divinity Tokens";
            }
            if (skillLevel05 == 2)
            {
                rpText.text = rpLevel03.ToString() + " Research Points";
                dtText.text = dtLevel03.ToString() + " Divinity Tokens";
            }
            if (skillLevel05 == 3)
            {
                rpText.text = rpLevel04.ToString() + " Research Points";
                dtText.text = dtLevel04.ToString() + " Divinity Tokens";
            }
            if (skillLevel05 == 4)
            {
                rpText.text = rpLevel05.ToString() + " Research Points";
                dtText.text = dtLevel05.ToString() + " Divinity Tokens";
            }
            if (skillLevel05 == 5)
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 0;
                upgradeButton.GetComponent<CanvasGroup>().interactable = false;
                upgradeCosts.text = "No more upgrades!";
                rpText.text = "Maxed out.";
                dtText.text = "Cannot upgrade!";
            }
            else
            {
                upgradeButton.GetComponent<CanvasGroup>().alpha = 1;
                upgradeButton.GetComponent<CanvasGroup>().interactable = true;
            }
        }

    }
    
    public void ResetText() //used in the ResearchManager
    {
        tooltipSubjectText.text = "";
        tooltipDescriptionText.text = "";

        upgradeCosts.text = "";
        rpText.text = "";
        dtText.text = "";
        upgradeButton.GetComponent<CanvasGroup>().alpha = 0;
        upgradeButton.GetComponent<CanvasGroup>().interactable = false;

        //GetComponent<Button>().enabled = false;
    }
}
