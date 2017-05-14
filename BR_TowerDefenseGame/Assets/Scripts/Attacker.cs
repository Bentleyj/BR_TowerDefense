using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

    public float range;
    public float attackRate;
    private float lastAttackTime;
    public int damage;
	
	//// Update is called once per frame
	//public virtual void Update () {
		
	//}

    public bool Attack(HealthyObject obj)
    {
        if((obj.transform.position - transform.position).magnitude < range)
        {
            if(Time.time - lastAttackTime > 1.0f / attackRate)
            {
                obj.health -= damage;
                lastAttackTime = Time.time;
                return true;
            }
        }
        return false;
    }
}
