using UnityEngine;
using System.Collections;

public class wavespawner : MonoBehaviour
{
    [Header("Enemy Settings")]
    public GameObject enemyPrefab;
    public Transform spawnPoint;

    [Header("Wave Setup (Set Manually In Inspector)")]
    public int[] enemiesPerWave;

    [Header("Timing")]
    public float spawnDelay = 1f;
    public float timeBetweenWaves = 5f;

    [Header("Flat Ground Randomness")]
    public float xRandomRange = 0.5f;

    private int currentWave = 0;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        while (currentWave < enemiesPerWave.Length)
        {
            int enemiesToSpawn = enemiesPerWave[currentWave];

            Debug.Log("Wave " + (currentWave + 1));

            for (int i = 0; i < enemiesToSpawn; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(spawnDelay);
            }

            currentWave++;

            yield return new WaitForSeconds(timeBetweenWaves);
        }

        Debug.Log("All Waves Completed!");
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xRandomRange, xRandomRange);

        Vector3 spawnPosition = new Vector3(
            spawnPoint.position.x + randomX,
            spawnPoint.position.y,
            spawnPoint.position.z
        );

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}