using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour {

    public float life;
    public Follow follower;
    public bool example = false;
    public Color color;
    public Renderer rend;

    // Use this for initialization
    void Start()
    {
        if (!follower)
            follower = GetComponent<Follow>();
        if (!rend)
            rend = GetComponentInChildren<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if(!example)
        {
            if (life <= 0 || (transform.localPosition - follower.targetObject.transform.localPosition).magnitude < 1.0)
            {
                Destroy(gameObject);
            }
            rend.material.SetColor("_Color", color);
            color = Color.Lerp(color, Color.white, 0.1f);
        }

    }
}
