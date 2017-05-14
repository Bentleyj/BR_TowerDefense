using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthyObject : MonoBehaviour {

    public int health;
    public int maxHealth;
    public HealthBarController bar;

	// Use this for initialization
	public virtual void Start () {
        if (!bar)
            bar = GetComponentInChildren<HealthBarController>();

        if (bar)
            bar.maxHealth = maxHealth;
	}
	
	// Update is called once per frame
	public virtual void Update () {
        if (bar)
            bar.health = health;
	}
}
