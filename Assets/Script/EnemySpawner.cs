using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public float numberToSpawn;
    public float spawnDelay;
    public GameObject EnemyPrefab;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", 0f,spawnDelay);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Spawn()
    {
        if (numberToSpawn > 0)
            Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
    }
}
