using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public static int damageRaw; //raw amount of damage dealt (all elements combined)

    private Transform target;
    
	public float speed = 70f;
	//public int damage = 50; //
	public float explosionRadius = 0f;
    //public int fireRate = 1f; // ADD THIS FROM CS.TURRET??
	public GameObject impactEffect; //on hit effect prefab

    [Header("Damage types")]
    public int damageEarth;
    public int damageFire;
    public int damageWater;

    //
    private float particleScale;

    //public float timeStunned = 1f;


    //Make ImpactEffect Stationary on turret location
    //private Vector3 a;
    //private Quaternion b;

    private Vector3 a;



    public void Seek (Transform _target)
	{
		target = _target;
	}
    
	//
	void Start ()
	{
        damageRaw = damageEarth + damageFire + damageWater;

		impactEffect.transform.localScale = new Vector3 (1,1,1);
	
		particleScale = explosionRadius * 0.36f;
		impactEffect.transform.localScale += new Vector3 (particleScale, particleScale, particleScale);


        //a = transform.position; //position of the turret
        //b = transform.rotation; //rotation of the turret

        a = target.position;// enemy position once projectile is fired

    }

	
	// Update is called once per frame
	void Update () {
		
		//if (target == null && impactEffect.name != "MeteorImpactEffect" || impactEffect.name != "AquaSprayImpactEffect")
		//{
		//	Destroy (gameObject);
		//	return;
		//}

        if (impactEffect.name == "?")
        {
            //Debug.Log("Aqua Spray");
            Vector3 dir = a - transform.position;
            float distanceThisFrame = speed * Time.deltaTime;

            if (dir.magnitude <= distanceThisFrame)
            {
                HitTarget();
                return;
            }

            transform.Translate(dir.normalized * distanceThisFrame, Space.World);
            transform.LookAt(target); //rotates the bullet
        }
        if (impactEffect.name == "MeteorImpactEffect")
        {
            Debug.Log("Meteor");
            Vector3 dir = a - transform.position;
            float distanceThisFrame = speed * Time.deltaTime;

            if (dir.magnitude <= distanceThisFrame)
            {
                HitTarget();
                return;
            }

            transform.Translate(dir.normalized * distanceThisFrame, Space.World);
            transform.LookAt(target); //rotates the bullet
        }


        if (impactEffect.name != "MeteorImpactEffect")// && impactEffect.name != "?")
        {
            if (target == null)
            {
            	Destroy (gameObject);
            	return;
            }

            Debug.Log("Not a Meteor or Aqua Spray");
            Vector3 dir = target.position - transform.position;
            float distanceThisFrame = speed * Time.deltaTime;

            if (dir.magnitude <= distanceThisFrame)
            {
                HitTarget();
                return;
            }

            transform.Translate(dir.normalized * distanceThisFrame, Space.World);
            transform.LookAt(target);
        }
    }

    //void HitAOE()
    //{
    //    GameObject effectIns = (GameObject)Instantiate(impactEffect, a, b); //change position/rotation to the tower instead of target

    //    Destroy(effectIns, 5f);
    //}
    
    void HitTarget ()
	{
        
        //Debug.Log ("WE HIT SOMETHING!");
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation); // (impactEffect, transform.position, transform.rotation);

        Destroy(effectIns, 5f);
        

        if (explosionRadius > 0f) 
		{
			Explode ();
		}
		else 
		{
			Damage (target);
		}

		Destroy(gameObject);
	}

	void Explode ()
	{
		//??set the scale of the particles to be equal to the explosionRadius. DONE

		Collider[] colliders = Physics.OverlapSphere (transform.position, explosionRadius);
		foreach (Collider collider in colliders)
		{
			if (collider.tag == "Enemy")
			{
				Damage (collider.transform);
			}
		}
	}

	public void Damage (Transform enemy) // -public
	{
		Enemy e = enemy.GetComponent<Enemy> ();
        //EnemyDebuffs ed = enemy.GetComponent<EnemyDebuffs>();

        if (e != null) //if it's an enemy
		{
            //ADD ? gained per hit?
            e.TakeDamageEarth(damageEarth);
            e.TakeDamageFire(damageFire);
            e.TakeDamageWater(damageWater);
            //ADD on-hit status effects?>?

            if (impactEffect.name == "MeteorImpactEffect")
            {
                //Debug.Log("MeteorImpactEffect");
                e.Stunned(1.2f); //duration stunned
            }
            if (impactEffect.name == "FireballImpactEffect")
            {
                //Debug.Log("FireballImpactEffect");
                e.DamageOverTime(100, 3); //damage / duration
            }

        }
        //Destroy (enemy.gameObject);
    }

    void OnDrawGizmosSelected ()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, explosionRadius);
	}
}
