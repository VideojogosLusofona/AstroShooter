using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject   explosionPrefab;

    [HideInInspector] public float          damage;
    [HideInInspector] public float          speed;
    [HideInInspector] public float          duration;
    [HideInInspector] public Ship.Faction   faction;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = transform.position + transform.forward * speed * Time.deltaTime;

        duration -= Time.deltaTime;
        if (duration < 0.0f)
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Asteroid")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if ((other.tag == "Player") || (other.tag == "Enemy"))
        {
            Ship ship = other.GetComponent<Ship>();
            if (ship.faction != faction)
            {
                ship.DealDamage(damage);
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
