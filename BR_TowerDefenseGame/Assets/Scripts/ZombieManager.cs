using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieManager : MonoBehaviour {

    public GameObject zombie;

    public float spawnRate;

    private float lastSpawnTime;

    public float spawnDistance;

    public float initialSpeedMin;
    public float initialSpeedMax;

    public HealthyObject homeBase;

    //[HideInInspector]
    public List<ZombieController> zombies;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time - lastSpawnTime > 1 / spawnRate)
        {
            GameObject z = Instantiate(zombie);
            Vector2 pos = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized * spawnDistance;
            z.transform.localPosition = new Vector3(pos.x, 0, pos.y);
            z.GetComponent<Follow>().speed = Random.Range(initialSpeedMin, initialSpeedMax);
            z.GetComponent<Follow>().targetPos = homeBase.transform;
            z.GetComponent<SlerpToLookAt>().Target = homeBase.transform;
            z.GetComponent<ZombieAttack>().target = homeBase;
            z.GetComponent<ZombieController>().example = false;
            lastSpawnTime = Time.time;
            zombies.Add(z.GetComponent<ZombieController>());
        }

        for(int i = 0; i < zombies.Count; i++)
        {
            if(zombies[i] == null)
            {
                zombies.RemoveAt(i);
            }
        }
	}
}
