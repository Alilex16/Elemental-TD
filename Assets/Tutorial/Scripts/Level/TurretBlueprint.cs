using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TurretBlueprint {
	
	public GameObject prefab; //Prefab to Basic Tower
	//public int cost; //TO REMOVE


    //Basic
	public GameObject earthTowerSkill01; //Prefab to the Earth tower -> CHANGE TO -> First skill. NO@
    public GameObject earthTowerSkill02;
    public GameObject earthTowerSkill03;
    public GameObject fireTowerSkill01; //Prefab to the Earth tower -> CHANGE TO -> First skill. NO@
    public GameObject fireTowerSkill02;
    public GameObject fireTowerSkill03;
    public GameObject waterTowerSkill01; //Prefab to the Earth tower -> CHANGE TO -> First skill. NO@
    public GameObject waterTowerSkill02;
    public GameObject waterTowerSkill03;


    //Enhanced
    public GameObject metalTowerSkill01;
    public GameObject lightningTowerSkill01;
    public GameObject iceTowerSkill01;


    //Combined
    public GameObject lavaTowerSkill01;
    public GameObject steamTowerSkill01;
    public GameObject mudTowerSkill01;



    //public GameObject fireTower; //Prefab to the Fire tower -> CHANGE TO -> Second skill
    //public GameObject waterTower; //Prefab to the Water tower -> CHANGE TO -> Third skill


    //public int upgradeCost; //TO REMOVE

    // public int GetSellAmount ()
    // {
    //     when selling, you get back the Elemental Gem, returning it to its base value (skills chosen are not remembered)
    //     return cost / 2;
    // }


}
