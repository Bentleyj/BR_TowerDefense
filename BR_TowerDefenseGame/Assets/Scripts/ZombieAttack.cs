using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : Attacker
{

    public HealthyObject target;
    public AudioSource zombieSound;
    public Follow movement;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool hit = Attack(target);
        if (hit)
        {
            zombieSound.Play();
            movement.speed = 0.0f;
        }
    }
}
