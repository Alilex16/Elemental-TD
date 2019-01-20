using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

	private Transform target;
	private Enemy targetEnemy;

	[Header("General")]

	public float range = 15f;
    public static float installmentTimer = 10f; //@ void Start. Delay before firing

	[Header("Use Bullets (default)")]
	public GameObject bulletPrefab;
	public float fireRate = 1f; // MOVE THIS TO CS.BULLET??
	private float fireCountDown = 0f;

	[Header("Use Laser")]
	public bool useLaser = false;

	public int damageOverTime = 30;
	public float slowAmount = 0.5f; // decrease enemy movement speed
    
	public LineRenderer lineRenderer;
	public ParticleSystem impactEffect;
	public Light impactLight;
    

    //[Header("Pulsating turret")]
    //[SerializeField] private bool pulsating = false;
    //public static bool AOE = false;
    //public GameObject impactAOE; //on hit effect prefab
    //private string water03 = "WaterTowerSkill03(Clone)";


    [Header("Unity Setup Fields")]
	public string enemyTag = "Enemy";
	public Transform partToRotate;
	public float turnSpeed = 10f;

	public Transform firePoint;

    [Header("Particles")]
    public GameObject entireParticle;
    public ParticleSystem finishParticle;
    private bool timerEffectsDone;


    //public ParticleSystem incinerateParticle;


    void Start ()
	{
        InvokeRepeating("UpdateTarget", installmentTimer, 0.25f); //Original Repeat = 0.5f

        //timerCanvas.SetActive(true);
        //InvokeRepeating ("UpdateTarget", installmentTimer, 0.25f); //Original Repeat = 0.5f
        //AOE = AOEActive; //
        //timerCanvas.GetComponent<Canvas>().enabled = true;
        Invoke("ParticleTimerEffectsStart", installmentTimer);
    }

    void UpdateTarget () //add if/bool, when regular shooting tower
	{
		GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
		float shortestDistance = Mathf.Infinity;
		GameObject nearestEnemy = null;

		foreach (GameObject enemy in enemies)
		{
			float distanceToEnemy = Vector3.Distance (transform.position, enemy.transform.position);
			if (distanceToEnemy < shortestDistance)
			{
				shortestDistance = distanceToEnemy;
				nearestEnemy = enemy;
			}
		}

		if (nearestEnemy != null && shortestDistance <= range) {
			target = nearestEnemy.transform;
			targetEnemy = nearestEnemy.GetComponent<Enemy> ();
		}
		else
		{
			target = null;
		}
	}
    
    void ParticleTimerEffectsStart()
    {
        finishParticle.Play();
        entireParticle.SetActive(true);
        Invoke("ParticleTimerEffects", 0.5f);
        //timerEffectsDone = true;
        //finishParticle.Stop();
    }


    void ParticleTimerEffects()
    {
        //entireParticle.SetActive(true);
        //timerEffectsDone = true;
        finishParticle.Stop ();
    }
    
    void Update ()
	{
        //if (installmentTimer - Time.time <= 0 && timerEffectsDone == false) //when timer reaches 0, turret is functional
        //{
            //finishParticle.gameObject.SetActive (true);
            //finishParticle.Play();

            //Invoke("ParticleTimerEffects", 0.5f);
        //}

		if (target == null)
		{
			if (useLaser)
			{
				if (lineRenderer.enabled)
				{
					lineRenderer.enabled = false;
					impactEffect.Stop ();
					impactLight.enabled = false;
				}
			}
			return;
		}

		LockOnTarget ();

		if (useLaser)
		{
			Laser ();
		}
		else
		{
			if (fireCountDown <= 0f)
			{
				Shoot ();
				fireCountDown = 1f / fireRate;
			}

			fireCountDown -= Time.deltaTime;
		}
	}

	void LockOnTarget ()
	{
		Vector3 dir = target.position - transform.position;
		Quaternion lookRotation = Quaternion.LookRotation(dir);
		Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
		partToRotate.rotation = Quaternion.Euler (0f, rotation.y, 0f);
	}

	void Laser ()
	{
		targetEnemy.TakeDamageFire(damageOverTime * Time.deltaTime); //FIRE? Not used anyway
		targetEnemy.Slow (slowAmount);
		//register debuff (call debuff script, containing all the debuffs)
        
		//Graphics
		if (!lineRenderer.enabled)
		{
			lineRenderer.enabled = true;
			impactEffect.Play (); //particles, always use play, not enabled
			impactLight.enabled = true;
		}
		
		lineRenderer.SetPosition (0, firePoint.position);
		lineRenderer.SetPosition (1, target.position);

		//rotates to position of your fire point, calculated from the target. b - a
		Vector3 dir = firePoint.position - target.position;
		impactEffect.transform.position = target.position + dir.normalized; // * 0.5f

		impactEffect.transform.rotation = Quaternion.LookRotation (dir);
	}
    

	void Shoot ()
	{
        //if (GameObject.Find(water03))
        //{
        //    Debug.Log("Water03 Shoots");
        //}


        //if (incinerateObject.name == "Incinerate")
        //{
        //    if (target != null)
        //    {
        //        incinerateObject.Play();
        //    }
        //    else
        //    {
        //        incinerateObject.Stop();
        //    }
        // }
        //else
        //{
            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Bullet bullet = bulletGO.GetComponent<Bullet>();

            if (bullet != null)
                bullet.Seek(target);
        //}

    }
    
	//if you want it always on, not just when turret is selected, remove the Selected
	void OnDrawGizmosSelected () 
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, range);
	}


}
