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
    public float numberAtFirstWave;
    public float bonusPerWave;
    public GameObject[] spawners;
    public float timeBetweenWaves;
    public int wave = 0;
    public bool waveInProgress = false;
    public float currentWaveCount;
    public bool spawningWait = false;

	// Use this for initialization
	void Start () {
        spawners = GameObject.FindGameObjectsWithTag("Respawn");
        StartNewWave();
	}
	
	// Update is called once per frame
	void Update () {
        if (enemies.Count > 0 && spawningWait)
            spawningWait = false;

        if (enemies.Count == 0 && waveInProgress && !spawningWait)
        {
            waveInProgress = false;
        }
        if (enemies.Count == 0 && !waveInProgress)
        {
            StartCoroutine("StartNewWave");
        }
    }
    IEnumerator StartNewWave()
    {
        waveInProgress = true;
        spawningWait = true;
        yield return new WaitForSeconds(timeBetweenWaves);
        currentWaveCount = numberAtFirstWave + (bonusPerWave * wave);
        wave++;
        if(currentWaveCount > spawners.Length)
        {
            float monsterPerSpawner = (int)currentWaveCount / spawners.Length;
            foreach (GameObject spawn in spawners)
            {

                spawn.GetComponent<EnemySpawner>().numberToSpawn = monsterPerSpawner;
                currentWaveCount -= monsterPerSpawner;
            }
        }
        for (int i = 0; i < currentWaveCount; ++i)
            spawners[Random.Range(0, spawners.Length)].GetComponent<EnemySpawner>().numberToSpawn++;
        yield return null;
    }
}
