using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawn : MonoBehaviour {
    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 3f;
    public GameObject meteorPrefab;

	// Use this for initialization
	void Start () {
        Spawn();
		
	}

    void Spawn()
    {
        //create a meteor at a random x position
        Vector3 spawnPos = transform.position + new Vector3(Random.Range(-6, 6), 0, 0);
        Instantiate(meteorPrefab, spawnPos, Quaternion.identity);

        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
