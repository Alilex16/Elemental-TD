using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))] // used for the enemy.speed
public class EnemyMovement : MonoBehaviour {

	private Transform target;
	private int wavepointIndex = 0;

	private Enemy enemy; // used for the enemy.speed


	void Start ()
	{
		enemy = GetComponent<Enemy> (); // used for the enemy.speed
		target = Waypoints.points[0];
	}


	void Update ()
	{
		//move toward waypoints, until it arrives
		Vector3 dir = target.position - transform.position;
		transform.Translate (dir.normalized * enemy.speed * Time.deltaTime, Space.World);

		//within a certain distance is fine
		if (Vector3.Distance (transform.position, target.position) <= 0.4f) {
			GetNextWaypoint ();
		}

		enemy.speed = enemy.startSpeed;

	}

	//proceed to next waypoint
	void GetNextWaypoint()
	{
		if (wavepointIndex >= Waypoints.points.Length - 1)
		{ 
			EndPath ();
			return;
		}

		wavepointIndex++;
		target = Waypoints.points [wavepointIndex];
	}

	void EndPath()
	{
		PlayerStats.Lives--;
		WaveSpawner.EnemiesAlive--;
		Destroy (gameObject);
	}



}
