using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarController : MonoBehaviour {

    public int health;
    public int maxHealth;
    public GameObject back;
    public GameObject front;
    //public Vector3 scale;

    float map(float value, float low1, float high1, float low2, float high2)
    {
        return low2 + (value - low1) * (high2 - low2) / (high1 - low1);
    }

	// Use this for initialization
	void Start () {
        health = maxHealth;
        //transform.localScale = scale;
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Camera.main.transform.rotation;
        Vector3 scale = front.transform.localScale;
        //Debug.Log();
        front.transform.localScale = new Vector3(map((float)health, (float)maxHealth, 0.0f, 1.0f, 0.0f), scale.y, scale.z);
    }
}
