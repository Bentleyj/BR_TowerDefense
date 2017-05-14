using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBaseController : HealthyObject {


	// Use this for initialization
	public override void Start () {
        base.Start();
    }
	
	// Update is called once per frame
	public override void Update () {
        base.Update();
        if(health == 0)
        {
            // Handle losing the game!
            Debug.Log("You Lost!");
        }
	}

}
