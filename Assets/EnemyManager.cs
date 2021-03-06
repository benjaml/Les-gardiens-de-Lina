﻿using UnityEngine;
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
    public float numberAtFirstWave;
    public float bonusPerWave;
    public GameObject[] spawners;
    public float timeBetweenWaves;
    public int wave = 0;
    public bool waveInProgress = false;
    public float currentWaveCount;
    public float totalCount;
    public bool spawningWait = false;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        if (totalCount > 50)
        {
            spawners[1].SetActive(true);
        }
        if (totalCount > 100)
        {
            spawners[5].SetActive(true);
        }
        if (totalCount > 200)
        {
            spawners[3].SetActive(true);
        }
        if (totalCount > 350)
        {
            spawners[7].SetActive(true);
        }

    }
    public void StopSpawn()
    {
        foreach(GameObject spawn in spawners)
        {
            Destroy(spawn);
        }
        Destroy(this);
    }
}
