using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

	public static int EnemiesAlive = 0;

	public Wave[] waves;

	//public Transform enemyPrefab;
	public Transform spawnPoint;

	public float timeBetweenWaves = 5f;
	private float countdown = 10.02f; //time before first wave is spawned

	public Text waveCountdownText;
	public Text waveCountText;

	public GameManager gameManager;

	private int waveIndex = 0;
    
	void OnEnable ()
	{
        this.GetComponent<GameSpeed>().PauseGameNew(); //starts a new game on Pause
        EnemiesAlive = 0;
	}
    
    void Update ()
	{
		waveCountText.text = "Wave: " + PlayerStats.Rounds.ToString();

        if (EnemiesAlive > 0) //condition to only start the next wave, when all enemies of the previous wave is dead
        {
            return;
        }

        if (waveIndex == waves.Length)
        {
            gameManager.WinLevel();
            this.enabled = false; //disables the script
                                  //show won screen - cash earned / #monsters killed / wave reached
                                  //return to menu
        }
        
		if (countdown <= 0f)
		{
			StartCoroutine(SpawnWave());
			countdown = timeBetweenWaves;
			return;
		}

		countdown -= Time.deltaTime;

		countdown = Mathf.Clamp (countdown, 0f, Mathf.Infinity);

		waveCountdownText.text = string.Format ("{0:00.00}", countdown);

		//waveCountdownText.text = Mathf.Round(countdown).ToString(); //Mathf.Floor means round down to integer number
	}

	IEnumerator SpawnWave ()
	{
		//Debug.Log ("Wave Incomming!");

		PlayerStats.Rounds++;

		Wave wave = waves [waveIndex];

        //EnemiesAlive = wave.count + wave.count2 + wave.count3; //count enemies before they're spawned OLD

        int totalEnemies01 = wave.count / BattleTraitsEnemyAmount.amountTrait01 * BattleTraitsEnemyAmount.amountTrait02;
        int totalEnemies02 = wave.count2 / BattleTraitsEnemyAmount.amountTrait01 * BattleTraitsEnemyAmount.amountTrait02;
        int totalEnemies03 = wave.count3 / BattleTraitsEnemyAmount.amountTrait01 * BattleTraitsEnemyAmount.amountTrait02;
        
        //EnemiesAlive = wave.count + wave.count2 + wave.count3; // OLD
        EnemiesAlive = totalEnemies01 + totalEnemies02 + totalEnemies03; //count enemies before they're spawned

        for (int i = 0; i < totalEnemies01; i++) //OLD: for (int i = 0; i < wave.count; i++)
        {
			spawnEnemy(wave.enemy);
			yield return new WaitForSeconds (1f / wave.rate); // wave.rate = 2 -> 2 per second
		}

		for (int i = 0; i < totalEnemies02; i++)
		{
			spawnEnemy(wave.enemy2);
			yield return new WaitForSeconds (1f / wave.rate2); // wave.rate = 10 -> 10 per second
		}
		for (int i = 0; i < totalEnemies03; i++)
		{
			spawnEnemy(wave.enemy3);
			yield return new WaitForSeconds (1f / wave.rate3); // wave.rate = 20 -> 20 per second
		}

		waveIndex++;

	}

	void spawnEnemy (GameObject enemy)
	{
		Instantiate (enemy, spawnPoint.position, spawnPoint.rotation);
	}
		
}
