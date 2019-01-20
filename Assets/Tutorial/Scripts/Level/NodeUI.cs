using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class NodeUI : MonoBehaviour {

	public GameObject ui; //Gem Selection
    public GameObject buttonBase; //Gem Selection
    public GameObject buttonEnhanced; //Gem Selection enhanced
    public GameObject buttonCombined; //Gem Selection combined
    public GameObject uiGeneral; //Gem Selection

    [Header("Hiding Skill Selection")]
    public GameObject uiEarthSkill; //
    public GameObject uiFireSkill; //
    public GameObject uiWaterSkill; //

    [Header("Imaging")]
    public GameObject imageEarth;
    public GameObject coverUpEarth;
    public GameObject imageFire;
    public GameObject coverUpFire;
    public GameObject imageWater;
    public GameObject coverUpWater;
    
    [Header("TO REMOVE / Elemental Gem Buttons")]
    public Button selectGemEarth;
    public Button selectGemFire;
    public Button selectGemWater;

    [Header("To Remove")]
    public Text upgradeCost; // TO REMOVE
    public Button upgradeButton; // TO REMOVE



    //[Header("Installment Timer")]
    //public GameObject timerCanvas; ///


    //public Text sellAmount;

    private Node target;


    //private void Update()
    //{
       // if (TurretInstallment.dtStatic >= TurretInstallment.timerCountdownStatic)
        //{
         //   //Destroy(timerCanvas);
         //   timerCanvas.SetActive(false);
         //   TurretInstallment.dtStatic = 0;
       // }
    //}



    public void SetTarget (Node _target) // add turret tooltip to this?
	{
		target = _target;

		transform.position = target.GetBuildPosition();

        //if (EventSystem.current.IsPointerOverGameObject())
        //{
        //    Debug.Log("Test");
        //}
        //else
        //{
        //    Debug.Log("Test Failed");
        //}

        if (PlayerStats.gemsEarthAmount >= 1)
        {
            //selectGemEarth.interactable = true;
            //thingy.GetComponent<CanvasGroup>().alpha = 1f; //
            imageEarth.GetComponent<Image>().enabled = true; //
            coverUpEarth.GetComponent<Image>().enabled = false; //
        }
		else 
		{
            //selectGemEarth.interactable = false;
            //thingy.GetComponent<CanvasGroup>().alpha = 0.4f; // 
            imageEarth.GetComponent<Image>().enabled = false; //disables the Hover Mouse Over, by removing the Image
            coverUpEarth.GetComponent<Image>().enabled = true; // enables the Cover Up Image, so the spot will not be completely empty
        }

        if (PlayerStats.gemsFireAmount >= 1)
        {
            imageFire.GetComponent<Image>().enabled = true; //
            coverUpFire.GetComponent<Image>().enabled = false; //
        }
        else
        {
            imageFire.GetComponent<Image>().enabled = false;
            coverUpFire.GetComponent<Image>().enabled = true;
        }

        if (PlayerStats.gemsWaterAmount >= 1)
        {
            imageWater.GetComponent<Image>().enabled = true; //
            coverUpWater.GetComponent<Image>().enabled = false; //
        }
        else
        {
            imageWater.GetComponent<Image>().enabled = false;
            coverUpWater.GetComponent<Image>().enabled = true;
        }

        ui.SetActive(true);
        buttonBase.SetActive(true);
        buttonEnhanced.SetActive(false);
        buttonCombined.SetActive(false);
        uiGeneral.SetActive(true);


        //if (Input.GetMouseButtonDown(0))
        //{
        //    shows turret info?
        //    Debug.Log("Get Mouse Down");
        //}

    }

    public void Hide ()
	{
		ui.SetActive(false);
        buttonBase.SetActive(false);
        buttonEnhanced.SetActive(false);
        buttonCombined.SetActive(false);
        uiGeneral.SetActive(false);
        uiEarthSkill.SetActive(false);
        uiFireSkill.SetActive(false);
        uiWaterSkill.SetActive(false);
    }

    public void ButtonEarth01 ()
    {
        //timerCanvas.SetActive(true);
        //GameObject _copy = (GameObject)Instantiate(timerCanvas, transform.position, Quaternion.identity);
        //_copy.transform.SetParent(transform); 

        target.EarthTurret01();
        BuildManager.instance.DeselectNode ();
    }
    public void ButtonEarth02()
    {
        target.EarthTurret02(); //Node.cs
        BuildManager.instance.DeselectNode();
        //ui.SetActive(false);
        //uiSkill.SetActive(true);
    }
    public void ButtonEarth03()
    {
        target.EarthTurret03(); //Node.cs
        BuildManager.instance.DeselectNode();
        //ui.SetActive(false);
        //uiSkill.SetActive(true);
    }

    public void ButtonFire01()
    {
        target.FireTurret01(); //Node.cs
        BuildManager.instance.DeselectNode();
    }
    public void ButtonFire02()
    {
        target.FireTurret02(); //Node.cs
        BuildManager.instance.DeselectNode();
    }
    public void ButtonFire03()
    {
        target.FireTurret03(); //Node.cs
        BuildManager.instance.DeselectNode();
    }

    public void ButtonWater01()
    {
        target.WaterTurret01(); //Node.cs
        BuildManager.instance.DeselectNode();
    }
    public void ButtonWater02()
    {
        target.WaterTurret02(); //Node.cs
        BuildManager.instance.DeselectNode();
    }
    public void ButtonWater03()
    {
        target.WaterTurret03(); //Node.cs
        BuildManager.instance.DeselectNode();
    }
    

    public void ButtonRemoveGem() //remove/disable this button if no gem is in there!
    {
        target.RemoveGem(); //Node.cs
        BuildManager.instance.DeselectNode();
    }

    //public void Upgrade ()
    //{
    //	target.UpgradeTurret();
    //	BuildManager.instance.DeselectNode ();
    //}

    public void SellBase()
    {
        target.SellTurretBase(); //Node.cs
        BuildManager.instance.DeselectNode();
    }
}





//// BACKUP:

//public void SetTarget(Node _target)
//{
//    target = _target;
//
//    transform.position = target.GetBuildPosition();


//    if (!target.isUpgraded)
//    {//updates the costs for upgrading
//       upgradeCost.text = "$" + target.turretBlueprint.upgradeCost;
//       upgradeButton.interactable = true;
//    }
//    else
//    {//upgrade is done
//       upgradeCost.text = "Maxed out";
//       upgradeButton.interactable = false;
//   }
   
    //sellAmount.text = "$" + target.turretBlueprint.GetSellAmount ();

//    ui.SetActive(true);
//}