using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    [Header("Gem UI")]
    public Text baseTowerLeftText;
    public Text gemsEarthLeftText;
    public Text gemsFireLeftText;
    public Text gemsWaterLeftText;
    public Text gemsMetalLeftText;
    public Text gemsLightningLeftText;
    public Text gemsIceLeftText;
    public Text gemsLavaLeftText;
    public Text gemsSteamLeftText;
    public Text gemsMudLeftText;
    

    void Awake ()
	{
        turretToBuild = null;

        if (instance != null)
		{
			Debug.LogError ("More than one BuildManager in scene!");
			return;
		}
		instance = this;
	}

	public GameObject buildEffect;
	public GameObject sellEffect;

    [HideInInspector]
    public TurretBlueprint turretToBuild; ////private

	private Node selectedNode;
    
    public NodeUI nodeUI;


    [HideInInspector]
    public TurretBlueprint turretBlueprint;


    //property, only get/check something, can not be set. Check if turret is able to build or not. If yes, then true. If not, then false.
    public bool CanBuild { get { return turretToBuild != null; } }


    //	public void BuildTurretOn (Node node)
    //	{
    //		if (PlayerStats.Money < turretToBuild.cost)
    //		{
    //			Debug.Log ("Not enough money to build that!");
    //			return;
    //		}
    //		PlayerStats.Money -= turretToBuild.cost;

    //		GameObject turret = (GameObject)Instantiate (turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
    //		node.turret = turret;

    //		GameObject effect = (GameObject)Instantiate (buildEffect, node.GetBuildPosition (), Quaternion.identity);
    //		Destroy (effect, 5f);

    //		Debug.Log ("Turret Build! Money left: " + PlayerStats.Money);
    //	}

    void Update()
    {
        baseTowerLeftText.text = PlayerStats.totalTurrets.ToString();
        gemsEarthLeftText.text = PlayerStats.gemsEarthAmount.ToString();
        gemsFireLeftText.text = PlayerStats.gemsFireAmount.ToString();
        gemsWaterLeftText.text = PlayerStats.gemsWaterAmount.ToString();
        gemsMetalLeftText.text = PlayerStats.gemsMetalAmount.ToString();
        gemsLightningLeftText.text = PlayerStats.gemsLightningAmount.ToString();
        gemsIceLeftText.text = PlayerStats.gemsIceAmount.ToString();
        gemsLavaLeftText.text = PlayerStats.gemsLavaAmount.ToString();
        gemsSteamLeftText.text = PlayerStats.gemsSteamAmount.ToString();
        gemsMudLeftText.text = PlayerStats.gemsMudAmount.ToString();
    }


    public void SelectNode (Node node)
	{
		if (selectedNode == node)
		{
			DeselectNode (); //Deselects the node with a tower
			return;
		}
        
        selectedNode = node;
		turretToBuild = null;

        nodeUI.SetTarget(node); //Shows UI

        //add an if statement, has it a targetable skill? if yes, click to place image, to set attack area
    }

	public void DeselectNode ()
	{
		selectedNode = null;
        nodeUI.Hide();
    }
    

	public void SelectTurretToBuild (TurretBlueprint turret) //when clicking on the tower
	{
		turretToBuild = turret;
        DeselectNode ();
	}

	public TurretBlueprint GetTurretToBuild () //when clicking on a node, to build the tower
	{
        // timer for basic tower??
        return turretToBuild;
	}

}
