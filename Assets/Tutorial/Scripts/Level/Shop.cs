using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    public TurretBlueprint basicTower;
    //public TurretBlueprint standardTurret;
    //public TurretBlueprint missileLauncher;
    //public TurretBlueprint laserBeamer;
    
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectBaseTurret() //BASE TOWER
    {
        Debug.Log("Basic Tower Selected");
        buildManager.SelectTurretToBuild(basicTower);
    }

    //
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            buildManager.SelectTurretToBuild(basicTower);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            buildManager.turretToBuild = null;
        }
    }
}


    //public void SelectStandardTurret ()
	//{
	//	Debug.Log ("Fast Tower Selected");
	//	buildManager.SelectTurretToBuild(standardTurret);
	//}

	//public void SelectMissileLauncher ()
   // {
	//	Debug.Log ("Affinity Tower Selected");
	//	buildManager.SelectTurretToBuild (missileLauncher);
	//}

    //	public void SelectLaserBeamer ()
    //   {
    //		Debug.Log ("Favorable Tower Selected");
    //		buildManager.SelectTurretToBuild (laserBeamer);
    //   }
    