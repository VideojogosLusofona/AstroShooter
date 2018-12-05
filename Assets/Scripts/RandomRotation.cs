using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour
{
    Vector3 rotationAxis;
    float   rotationSpeed;

	// Use this for initialization
	void Start ()
    {
        rotationAxis = Random.onUnitSphere;
        rotationSpeed = Random.Range(-45.0f, 45.0f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.rotation = transform.rotation * Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, rotationAxis);	
	}
}
