using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public GameObject targetObject;
 
    public float speed = 1.0f;

    private Transform targetPos;




	// Use this for initialization
	void Start () {

        targetPos = targetObject.transform;
   

		
	}
	
	// Update is called once per frame
	void Update () {
            transform.position = Vector3.Lerp(transform.position, targetPos.position, speed);
            
    }

    }
