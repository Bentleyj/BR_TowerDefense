﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunner : MonoBehaviour {

    public ZombieManager zManager;
    public AudioSource gunSound;
    public float range;
    public float fireRate;
    private float lastFireTime;
    public int damage;

	// Use this for initialization
	void Start () {
        if (!zManager)
            zManager = FindObjectOfType<ZombieManager>();
	}
	
	// Update is called once per frame
	void Update () {
        float nearestDist = 1000.0f;
        int nearestIndex = 0;
		for(int i = 0; i < zManager.zombies.Count; i++)
        {
            float dist = (new Vector2(zManager.zombies[i].transform.position.x, zManager.zombies[i].transform.position.z) - new Vector2(transform.position.x, transform.position.z)).magnitude;
            if (dist < nearestDist)
            {
                nearestDist = dist;
                nearestIndex = i;
            }
        }

        if(nearestDist < range && Time.time - lastFireTime > 1 / fireRate)
        {
            Shoot(nearestIndex);
        }
    }

    void Shoot(int i)
    {
        zManager.zombies[i].life -= damage;
        zManager.zombies[i].color = Color.red;
        lastFireTime = Time.time;
        gunSound.Play();
    }
}
