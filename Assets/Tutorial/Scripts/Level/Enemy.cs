using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    //public Text description; //Text to Display Enemy description
    //public GameObject description;

    public float startSpeed = 10f; //movement / baseSpeed
    private float realSpeed;
	[HideInInspector] //obviously..
	public float speed; //movement

    public float startHealth = 100; //baseHealth
    private float realHealth;
    private float health;

    public float baseHealthRegen = 0;
    public static float healthRegen; //not implemented yet

    [Header("Resistances")] // set a hard cap at 95%
    public float earthResistBase;
    public float fireResistBase;  //
    public float waterResistbase;

    private float earthResistTotal;
    private float fireResistTotal;
    private float waterResistTotal;

    //[Header("Effect Resistances")]

    [Header("RP (0 Favor) Gained per Kill")]
    public int earthWorth = 0; //favor gained for killing an enemy 
	public int fireWorth = 0;
    public int waterWorth = 0;
    private float worth;

	public GameObject deathEffect;

	[Header("Unity Stuff")]
	public Image healthBar;

	private bool isDead = false;

    
    void Start ()
	{
        realSpeed = startSpeed; //* battleTraitSpeed.speedTrait01;
        speed = realSpeed;
        realHealth = startHealth * BattleTraitsEnemyHP.healthTrait01;
        health = realHealth;

        earthResistTotal = earthResistBase + BattleTraitsEnemyResist.resistTrait01;
        fireResistTotal = fireResistBase + BattleTraitsEnemyResist.resistTrait01;
        waterResistTotal = waterResistbase + BattleTraitsEnemyResist.resistTrait01;

        healthRegen = baseHealthRegen;

        worth = 0; //reset worth, before calculating worth for the next kill. Needed?

        worth = (((speed * 10) + (health * 2) + (earthResistTotal + fireResistTotal + waterResistTotal)) / 100); //experimental
    }
    
    /// 
    void OnParticleCollision(GameObject other)
    {
        //print("HIT " + this);
        if (transform.tag == "Enemy")
        {
            //print("HIT " + this);
            this.TakeDamageFire(Incinerate.damage);//apply damage
        }
        
    }
    
    public void TakeDamageEarth(float amount)
	{
        //Debug.Log("Health before: " + health);
        //Debug.Log("Earth Resist Base: " + earthResistBase);
        //Debug.Log("Earth Resist Total: " + earthResistTotal);

        health -= (amount * (1 - (earthResistTotal / 100))); //experimental ??HOW TO GET 100 = half damage??

        //Debug.Log("Health after: " + health);
        Damaged();
    }

    public void TakeDamageFire(float amount)
    {
        health -= (amount * (1 - (fireResistTotal / 100)));
        Damaged();
    }

    public void TakeDamageWater(float amount)
    {
        health -= (amount * (1 - (waterResistTotal / 100)));
        Damaged();
    }

    public void Damaged()
    {
        healthBar.fillAmount = health / realHealth;

        if (health <= 0 && !isDead)
        {
            Die();
        }
    }

    public void RegenerateHealth()
    {
        health += healthRegen; //need to call this function from somewhere (possibly every few seconds?)
    }

    public void Slow (float pct)
	{
		speed = realSpeed * (1f - pct);
	}

	void Die ()
	{
		isDead = true;
        
        CalculateWorth(); //calculate worth of the kill

        PlayerStats.worthRP += worth; //Add RP gained for kill

		//PlayerStats.earthAffinity += earthWorth;
		//PlayerStats.fireAffinity += fireWorth;
		//PlayerStats.waterAffinity += waterWorth;

		GameObject effect = (GameObject) Instantiate (deathEffect, transform.position, Quaternion.identity); //spawns death effect on target location
		Destroy (effect, 5f);

		WaveSpawner.EnemiesAlive--;

		Destroy (gameObject); // has a delay!
	}

    //TESTING
    public void DamageOverTime(int damageAmount, int duration) //damageTime
    {
        StartCoroutine(DamageOverTimeCoroutine(damageAmount, duration)); //damageTime
    }
    
    public IEnumerator DamageOverTimeCoroutine(float damageAmount, float duration)
    {
        float amountDamaged = 0;
        float damagePerLoop = damageAmount / duration;
        while (amountDamaged < damageAmount)
        {
            health -= damagePerLoop;
            Damaged();
            //Debug.Log("TEST DoT." + health.ToString());
            amountDamaged += damagePerLoop;
            yield return new WaitForSeconds(1f);
        }
    }

    public void Stunned(float duration) //damageTime
    {
        StartCoroutine(StunnedCoroutine(duration)); //damageTime
    }

    public IEnumerator StunnedCoroutine(float duration)
    {
        float timePassed = 0;
        Debug.Log("Stun hit");
        //float timer = duration;
        //float damagePerLoop = timer / duration;

        while (timePassed < duration)
        {
            timePassed += Time.deltaTime;
            speed = 0f;
            Debug.Log("Stunned: " + timePassed + " seconds");
            yield return new WaitForSeconds(0f);
        }
    }
    

    void CalculateWorth() // this can be removed
    {
        //(((speed * 10) + (health * 2) + (resist + resist + resist)) / 10)
        //worth = ((speed * 10) + (health * 2) + (fireResist + earthResist + waterResist)) / 10;
        //Debug.Log("Worth: " + worth);
        //worth = 2;
    }
}
