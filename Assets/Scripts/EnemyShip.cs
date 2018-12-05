using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : Ship
{
    public float shotRate = 2.0f;

    float shotCooldown;

	// Use this for initialization
	void Start ()
    {
        shotCooldown = shotRate;
	}
	
	void Update ()
    {
        PlayerShip player = GameObject.FindObjectOfType<PlayerShip>();
        if (player == null) return;

        Vector3 delta = player.transform.position - transform.position;
        Vector3 targetDirection = new Vector3(delta.x, 0.0f, delta.z);

        if (delta.magnitude > 0.0f)
        {
            targetDirection = targetDirection.normalized;

            Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, maxRotationSpeed * Time.deltaTime);
        }

        transform.position = transform.position + transform.forward * maxSpeed * Time.deltaTime;

        shotCooldown -= Time.deltaTime;
        if (shotCooldown <= 0.0f)
        {
            float cosAngle = Vector3.Dot(transform.forward, targetDirection);
            if (cosAngle > 0.90f)
            {
                Shoot(targetDirection);
                shotCooldown = shotRate;
            }
        }
    }
}
