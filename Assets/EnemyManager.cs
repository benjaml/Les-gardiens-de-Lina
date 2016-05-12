using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour {

    public static EnemyManager Instance = null;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(this);
    }

    public List<GameObject> enemies = new List<GameObject>();
    public GameObject[] spawners;
    public float timeBetweenWaves;
    public int wave = 0;

	// Use this for initialization
	void Start () {
        wave = 1;
        spawners = GameObject.FindGameObjectsWithTag("Respawn");
	}
	
	// Update is called once per frame
	void Update () {
	    if(enemies.Count == 0)
        {
            StartNewWave();
        }
	}
    void StartNewWave()
    {
        wave++;

    }
}
