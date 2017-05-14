using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : Attacker {

    public ZombieManager zManager;
    public AudioSource gunSound;

	// Use this for initialization
	void Start () {
        if (!zManager)
            zManager = FindObjectOfType<ZombieManager>();
	}
	
	// Update is called once per frame
	void Update () {
        float nearestDist = 1000.0f;
        HealthyObject nearestObject = null;
		for(int i = 0; i < zManager.zombies.Count; i++)
        {
            float dist = (new Vector2(zManager.zombies[i].transform.position.x, zManager.zombies[i].transform.position.z) - new Vector2(transform.position.x, transform.position.z)).magnitude;
            if (dist < nearestDist)
            {
                nearestDist = dist;
                nearestObject = zManager.zombies[i];
            }
        }

        bool attacked = Attack(nearestObject);
        if (attacked)
            gunSound.Play();
    }
}
