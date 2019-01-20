using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPulsating : MonoBehaviour {
    
    public GameObject impactEffect;
    public static float installmentTimer = 10f;
    public float explosionRadius = 0f;
    public float pulseSpeed = 1.5f;
    
    [Header("Damage types")]
    public int damageEarth;
    public int damageFire;
    public int damageWater;

    [Header("Particles")]
    public GameObject entireParticle;
    public ParticleSystem finishParticle;

    private void Start()
    {
        InvokeRepeating("UpdateTarget", installmentTimer, pulseSpeed);

        Invoke("ParticleTimerEffectsStart", installmentTimer);
    }

    void ParticleTimerEffectsStart()
    {
        finishParticle.Play();
        entireParticle.SetActive(true);
        Invoke("ParticleTimerEffects", 0.5f);
    }

    void ParticleTimerEffects()
    {
        finishParticle.Stop();
    }
    
    void UpdateTarget()
    {
        //play animation
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation); // (impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 5f);
        
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.tag == "Enemy")
            {
                Damage(collider.transform);
                //show on-hit particle
            }
        }
    }

    public void Damage(Transform enemy) // -public
    {
        Enemy e = enemy.GetComponent<Enemy>();

        if (e != null) //if it's an enemy
        {
            //ADD ? gained per hit?
            e.TakeDamageEarth(damageEarth);
            e.TakeDamageFire(damageFire);
            e.TakeDamageWater(damageWater);
        }
    }
}
