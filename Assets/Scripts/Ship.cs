using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public enum Faction { Friend, Foe, Neutral };

    public Faction      faction;
    public float        thrustForce;
    public float        lateralThrustersForce;
    public float        maxSpeed;
    public float        maxRotationSpeed = 360.0f;
    public float        drag = 0.95f;
    public float        maxHealth = 100;
    public GameObject   explosionPrefab;
    [Header("Lasers (pew pew pew)")]
    public Shot     shotPrefab;
    public float    shotDamage;
    public float    shotSpeed;
    public float    shotDuration;

    float health;

    void Start () {
        health = maxHealth;

    }
	
	void Update () {
		
	}

    protected void Shoot(Vector3 direction)
    {
        Shot shot = Instantiate(shotPrefab, transform.position, Quaternion.LookRotation(direction, Vector3.up));
        shot.damage = shotDamage;
        shot.duration = shotDuration;
        shot.speed = shotSpeed;
        shot.faction = faction;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Asteroid")
        {
            Die();
        }
    }

    protected void Die()
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0.0f)
        {
            Die();
        }
    }
}
