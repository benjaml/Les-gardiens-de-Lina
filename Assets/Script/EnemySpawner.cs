using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{

    public float numberToSpawn;
    public float spawnDelay;
    public GameObject[] EnemyPrefab;
    public float spawnRadius;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 0f, spawnDelay);
    }

    void OnDrawGizmosSelected()
    {
        // Display the spawn radius when selected
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(transform.position, spawnRadius);
    }


    // Update is called once per frame


    void Spawn()
    {
        if (numberToSpawn > 0)
        {
            GameObject tmp = EnemyPrefab[Random.Range(0, EnemyPrefab.Length)];
            Vector3 spawnPosition = transform.position;
            spawnPosition += Vector3.right * Random.Range(-spawnRadius, spawnRadius);
            spawnPosition += Vector3.forward * Random.Range(-spawnRadius, spawnRadius);
            Instantiate(tmp, spawnPosition, Quaternion.identity);
            numberToSpawn--;
        }
    }
}
