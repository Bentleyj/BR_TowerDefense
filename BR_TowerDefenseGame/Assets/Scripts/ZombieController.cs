using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : HealthyObject {

    public bool example = false;
    public Color color;
    [HideInInspector]
    public Renderer rend;
    private Follow target;

    // Use this for initialization
    public override void Start()
    {
        base.Start();
        if (!rend)
            rend = GetComponentInChildren<Renderer>();
        if (!target)
            target = GetComponent<Follow>();
    }
	
	// Update is called once per frame
	public override void Update () {
        base.Update();
        if(!example)
        {
            if (health <= 0)
            {
                // Handle Zombie Death
                Destroy(gameObject);
            }
            rend.material.SetColor("_Color", color);
            color = Color.Lerp(color, Color.white, 0.1f);
        }
    }
}
