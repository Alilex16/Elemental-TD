using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour {

	public Color hoverColor;
	public Color notEnoughTurretsColor;
	public Vector3 positionOffset;

    //[Header("Clones")]
    private string basic = "BasicTower(Clone)";
    private string earth = "EarthTag";
    private string fire = "FireTag";
    private string water = "WaterTag";
    private string metal = "MetalTag";
    private string lightning = "LightningTag";
    private string ice = "IceTag";
    private string lava = "LavaTag";
    private string steam = "SteamTag";
    private string mud = "MudTag";

    //[Header("Optional")]
    [HideInInspector]
	public GameObject turret;
	[HideInInspector]
	public TurretBlueprint turretBlueprint;
	[HideInInspector]
	public bool isUpgraded = false;

	private Renderer rend;
	private Color startColor;
    
	BuildManager buildManager;

    

    void Start ()
	{
		rend = GetComponent<Renderer> ();
		startColor = rend.material.color;

		buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition ()
	{
		return transform.position + positionOffset;
	}
    
    void OnMouseDown ()
	{
		//is the pointer with the given ID over an eventsystem object, if yes, then exit on mouse down
		if (EventSystem.current.IsPointerOverGameObject ())
			return;

		if (turret != null) 
		{
			buildManager.SelectNode (this);
			return;
		}

		if (!buildManager.CanBuild)
			return;

        //GameObject turretTobuild = buildManager.GetTurretTobuild ();
        //turret = (GameObject)Instantiate(turretTobuild, transform.position + positionOffset, transform.rotation);

        //buildManager.BuildTurretOn (this);

        BuildTurret(buildManager.GetTurretToBuild());
	}

	void BuildTurret (TurretBlueprint blueprint)
	{
        //if (PlayerStats.Affinity < blueprint.cost)
        //{
        //	Debug.Log ("Not enough money to build that!");
        //	return;
        //}
        //PlayerStats.Affinity -= blueprint.cost;


        if (PlayerStats.totalTurrets >= 1) //&& turret != null)
        {
            PlayerStats.totalTurrets -= 1;
            GameObject _turret = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
            turret = _turret;

            turretBlueprint = blueprint;

            GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
            Destroy(effect, 5f);

            //InstallmentTimer(); // timer for basic tower??

            Debug.Log ("Tower built!");
        }
        else
        {
            Debug.Log("No towers left to place!");
        }
        
    }
    
    public void EarthTurret01() //Earth Turret, First Skill
    {
        ReturnOldGem();
        Debug.Log("Earth element activated!");
        PlayerStats.earthAffinity += PlayerStats.earthFavorPerTurret; //provides a base of 1 favor per second
        PlayerStats.gemsEarthAmount -= 1; //Removes 1 Earth Gem from the UI
        Destroy(turret);//Get rid of the old turret
        GameObject _turret = (GameObject)Instantiate(turretBlueprint.earthTowerSkill01, GetBuildPosition(), Quaternion.identity); //Build a new turret
        turret = _turret;
        GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);
    }
    public void EarthTurret02() //Earth Turret, Second Skill
    {
        ReturnOldGem();
        Debug.Log("Earth element activated!");
        PlayerStats.earthAffinity += PlayerStats.earthFavorPerTurret;
        PlayerStats.gemsEarthAmount -= 1; //Removes 1 Earth Gem from the UI
        Destroy(turret);//Get rid of the old turret
        GameObject _turret = (GameObject)Instantiate(turretBlueprint.earthTowerSkill02, GetBuildPosition(), Quaternion.identity); //Build a new turret
        turret = _turret;
        GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);
    }
    public void EarthTurret03() //Earth Turret, Third Skill
    {
        ReturnOldGem();
        Debug.Log("Earth element activated!");
        PlayerStats.earthAffinity += PlayerStats.earthFavorPerTurret;
        PlayerStats.gemsEarthAmount -= 1; //Removes 1 Earth Gem from the UI
        Destroy(turret);//Get rid of the old turret
        GameObject _turret = (GameObject)Instantiate(turretBlueprint.earthTowerSkill03, GetBuildPosition(), Quaternion.identity); //Build a new turret
        turret = _turret;
        GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);
    }
    
    public void FireTurret01()
    {
        ReturnOldGem();
        Debug.Log("Fire element activated!");
        PlayerStats.fireAffinity += PlayerStats.fireFavorPerTurret;
        PlayerStats.gemsFireAmount -= 1; //Removes 1 Fire Gem from the UI
        Destroy(turret); //Get rid of the old turret
        GameObject _turret = (GameObject)Instantiate(turretBlueprint.fireTowerSkill01, GetBuildPosition(), Quaternion.identity); //Build a new turret
        turret = _turret;
        GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);
    }
    public void FireTurret02()
    {
        ReturnOldGem();
        Debug.Log("Fire element activated!");
        PlayerStats.fireAffinity += PlayerStats.fireFavorPerTurret;
        PlayerStats.gemsFireAmount -= 1; //Removes 1 Fire Gem from the UI
        Destroy(turret); //Get rid of the old turret
        GameObject _turret = (GameObject)Instantiate(turretBlueprint.fireTowerSkill02, GetBuildPosition(), Quaternion.identity); //Build a new turret
        turret = _turret;
        GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);
    }
    public void FireTurret03()
    {
        ReturnOldGem();
        Debug.Log("Fire element activated!");
        PlayerStats.fireAffinity += PlayerStats.fireFavorPerTurret;
        PlayerStats.gemsFireAmount -= 1; //Removes 1 Fire Gem from the UI
        Destroy(turret); //Get rid of the old turret
        GameObject _turret = (GameObject)Instantiate(turretBlueprint.fireTowerSkill03, GetBuildPosition(), Quaternion.identity); //Build a new turret
        turret = _turret;
        GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);
    }

    public void WaterTurret01()
    {
        ReturnOldGem();
        Debug.Log("Water element activated!");
        PlayerStats.waterAffinity += PlayerStats.waterFavorPerTurret;
        PlayerStats.gemsWaterAmount -= 1; //Removes 1 Water Gem from the UI
        Destroy(turret); //Get rid of the old turret
        GameObject _turret = (GameObject)Instantiate(turretBlueprint.waterTowerSkill01, GetBuildPosition(), Quaternion.identity); //Build a new turret
        turret = _turret;
        GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);
    }
    public void WaterTurret02()
    {
        ReturnOldGem();
        Debug.Log("Water element activated!");
        PlayerStats.waterAffinity += PlayerStats.waterFavorPerTurret;
        PlayerStats.gemsWaterAmount -= 1; //Removes 1 Water Gem from the UI
        Destroy(turret); //Get rid of the old turret
        GameObject _turret = (GameObject)Instantiate(turretBlueprint.waterTowerSkill02, GetBuildPosition(), Quaternion.identity); //Build a new turret
        turret = _turret;
        GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);
    }
    public void WaterTurret03()
    {
        ReturnOldGem();
        Debug.Log("Water element activated!");
        PlayerStats.waterAffinity += PlayerStats.waterFavorPerTurret;
        PlayerStats.gemsWaterAmount -= 1; //Removes 1 Water Gem from the UI
        Destroy(turret); //Get rid of the old turret
        GameObject _turret = (GameObject)Instantiate(turretBlueprint.waterTowerSkill03, GetBuildPosition(), Quaternion.identity); //Build a new turret
        turret = _turret;
        GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);
    }
    //Debug.Log (GetInstanceID());

    // public void InstallmentTimer()
    //{
    //    Debug.Log("Installment timer Base");
    // }

    public void ReturnOldGem()
    {
        if (turret.CompareTag(earth))
        {
            PlayerStats.gemsEarthAmount += 1;
        }
        if (turret.CompareTag(fire))
        {
            PlayerStats.gemsFireAmount += 1;
        }
        if (turret.CompareTag(water))
        {
            PlayerStats.gemsWaterAmount += 1;
        }
        if (turret.CompareTag(metal))
        {
            PlayerStats.gemsEarthAmount += 2;
        }
        if (turret.CompareTag(lightning))
        {
            PlayerStats.gemsFireAmount += 2;
        }
        if (turret.CompareTag(ice))
        {
            PlayerStats.gemsWaterAmount += 2;
        }
        if (turret.CompareTag(lava))
        {
            PlayerStats.gemsEarthAmount += 1;
            PlayerStats.gemsFireAmount += 1;
        }
        if (turret.CompareTag(steam))
        {
            PlayerStats.gemsFireAmount += 1;
            PlayerStats.gemsWaterAmount += 1;
        }
        if (turret.CompareTag(mud))
        {
            PlayerStats.gemsEarthAmount += 1;
            PlayerStats.gemsWaterAmount += 1;
        }
    }
    
    public void RemoveGem()
    {
        //NOT working properly.. Finds all the turrets in the scene, and adds gems if it's there.
        //if (GameObject.FindWithTag(earth))
        //{
        //    PlayerStats.gemsEarthAmount += 1;
        //}
        //if (gameObject.CompareTag(earth))
        //{
        //    PlayerStats.gemsEarthAmount += 1;
        //}
        if (turret.CompareTag(earth))
        {
            PlayerStats.gemsEarthAmount += 1;
            PlayerStats.earthAffinity -= PlayerStats.earthFavorPerTurret; //removes a base of 1 favor per second
        }
        if (turret.CompareTag(fire))
        {
            PlayerStats.gemsFireAmount += 1;
            PlayerStats.fireAffinity -= PlayerStats.fireFavorPerTurret;
        }
        if (turret.CompareTag(water))
        {
            PlayerStats.gemsWaterAmount += 1;
            PlayerStats.waterAffinity -= PlayerStats.waterFavorPerTurret;
        }

        //destroy current tower and place an Basic Tower
        Destroy(turret);
        GameObject _turret = (GameObject)Instantiate(turretBlueprint.prefab, GetBuildPosition(), Quaternion.identity); //place back an empty turret
        turret = _turret; //treat it as turret (else the UI won't show up)
        

        //if (turret = turretBlueprint.earthTower as GameObject)
        //{
        //    PlayerStats.gemsEarthAmount += 1;
        //    Debug.Log("Return earth gem");
        //}
    }

    public void SellTurretBase()
    {
        //NOT working properly.. Finds all the turrets in the scene, and adds gems if it's there.
        //if (GameObject.FindWithTag(earth) && GameObject.Equals (earth, earth)) //PlayerStats.gemsEarthStart != PlayerStats.gemsEarthAmount
        //{
        //    PlayerStats.gemsEarthAmount += 1;
        //    DestroyOldTower();
        //}
        if (turret.CompareTag(earth)) //PlayerStats.gemsEarthStart != PlayerStats.gemsEarthAmount
        {
            PlayerStats.gemsEarthAmount += 1;
            PlayerStats.earthAffinity -= PlayerStats.earthFavorPerTurret;
            DestroyOldTower();
        }
        if (turret.CompareTag(fire)) //PlayerStats.gemsFireStart != PlayerStats.gemsFireAmount
        {
            PlayerStats.gemsFireAmount += 1;
            PlayerStats.fireAffinity -= PlayerStats.fireFavorPerTurret;
            DestroyOldTower();
        }
        if (turret.CompareTag(water)) //PlayerStats.gemsWaterStart != PlayerStats.gemsWaterAmount
        {
            PlayerStats.gemsWaterAmount += 1;
            PlayerStats.waterAffinity -= PlayerStats.waterFavorPerTurret;
            DestroyOldTower();
        }
        if (GameObject.Find(basic))
        {
            DestroyOldTower();
        }
        //PlayerStats.Favor -= if fire, lowers fire favor //+= turretBlueprint.GetSellAmount();
        //PlayerStats.totalTurrets += 1;
        //DestroyOldTower();
    }

    public void DestroyOldTower()
    {
        PlayerStats.totalTurrets += 1;

        GameObject effect = (GameObject)Instantiate(buildManager.sellEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);

        Destroy(turret);

        turretBlueprint = null;

        //Debug.Log("All good");
    }
    
	//triggers once every time the mouse enters its collider box
	void OnMouseEnter ()
	{

        //is the pointer with the given ID over an eventsystem object, if yes, then exit on mouse enter
        if (EventSystem.current.IsPointerOverGameObject ())
	    return;

		if (!buildManager.CanBuild)
			return;

		if (PlayerStats.totalTurrets >= 1)
		{
			rend.material.color = hoverColor;
		} 
		else 
		{
			rend.material.color = notEnoughTurretsColor;
		}
	}

	void OnMouseExit ()
	{
		rend.material.color = startColor;
	}
}
