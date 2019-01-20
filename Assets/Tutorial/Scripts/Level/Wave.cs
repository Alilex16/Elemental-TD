using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // should be saved and load, shown in inspector
public class Wave { // only used to store information

	public GameObject enemy;
	public GameObject enemy2;
	public GameObject enemy3;
	public int count; // amount of enemies spawning
	public int count2;
	public int count3;
	public float rate; //speed of enemies spawning
	public float rate2;
	public float rate3; 

}
