using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour {

    protected Plane plane;
    public Vector3 pSmooth;
    public GameObject target;
    [Range(0.01f, 1.0f)]
    public float trackingSpeed;

	// Use this for initialization
	void Start () {
        plane = new Plane(new Vector3(0, 1, 0), new Vector3(0, 0, 0));
	}
	
	// Update is called once per frame
	void Update () {
        //Vector3 forward = transform.forward * 1000;// new Vector3(transform.p.x, transform.localPosition.y, transform.localPosition.z + 50);
        //Debug.DrawLine(transform.position, transform.position + forward, Color.red);
        //Debug.Log("Position: " + transform.position);
        //Debug.Log("Forward: " + forward);
        Ray ray = new Ray(transform.position, transform.forward);
        float rayDistance;
        if(plane.Raycast(ray, out rayDistance))
        {
            pSmooth = Vector3.Lerp(pSmooth, ray.GetPoint(rayDistance), trackingSpeed);
            target.transform.position = pSmooth;
        }

    }
}
