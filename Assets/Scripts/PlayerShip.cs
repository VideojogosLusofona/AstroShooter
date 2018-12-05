using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : Ship
{
    [Header("Player Properties")]
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";
    public string shootButton = "Fire1";
    public string suicideButton = "Fire2";

    Vector3 velocity = Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}

    void Update()
    {
        // Movement
        Vector3 direction = new Vector3(Input.GetAxis(horizontalAxis), 0.0f, Input.GetAxis(verticalAxis));

        Vector3 acceleration = Vector3.zero;

        acceleration = Vector3.right * direction.x * lateralThrustersForce + Vector3.forward * direction.z * thrustForce;

        velocity = velocity * drag;
        velocity = velocity + acceleration * Time.deltaTime;

        velocity = velocity.normalized * Mathf.Clamp(velocity.magnitude, 0.0f, maxSpeed);

        transform.position = transform.position + velocity * Time.deltaTime;

        // Rotation
        Vector2 mousePosition = Input.mousePosition;
        Vector2 shipPositionInWorldSpace = Camera.main.WorldToScreenPoint(transform.position);

        Vector2 delta = mousePosition - shipPositionInWorldSpace;

        if (delta.magnitude > 0.0f)
        {
            delta = delta.normalized;

            Quaternion targetRotation = Quaternion.LookRotation(new Vector3(delta.x, 0.0f, delta.y), Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, maxRotationSpeed * Time.deltaTime);
        }

        if (Input.GetButtonDown(shootButton))
        {
            Shoot(transform.forward);
        }

        if (Input.GetButtonDown(suicideButton))
        {
            Die();
        }
    }
}
