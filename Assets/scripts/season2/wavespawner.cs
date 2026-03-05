// using UnityEngine;

// public class WaveSpawner : MonoBehaviour
// {
//     public GameObject enemyPrefab;

//     public Transform leftSpawn;
//     public Transform rightSpawn;

//     public float minSpawnDelay = 0.5f;
//     public float maxSpawnDelay = 2f;

//     public int enemiesPerWave = 5;

//     private int currentWave = 1;

//     public void StartWave()
//     {
//         StartCoroutine(SpawnWave());
//     }

//     private System.Collections.IEnumerator SpawnWave()
//     {
//         for (int i = 0; i < enemiesPerWave + currentWave; i++)
//         {
//             SpawnEnemy();

//             float delay = Random.Range(minSpawnDelay, maxSpawnDelay);
//             yield return new WaitForSeconds(delay);
//         }

//         currentWave++; // Increase difficulty every wave
//     }

//     void SpawnEnemy()
//     {
//         bool spawnLeft = Random.value > 0.5f;

//         Transform spawnPoint = spawnLeft ? leftSpawn : rightSpawn;

//         GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);

//         EnemyFollow ef = enemy.GetComponent<EnemyFollow>();

//         // Randomize difficulty slightly
//         ef.moveSpeed = Random.Range(2.5f, 4.5f);
//         ef.attackDistance = Random.Range(0.6f, 1.2f);
//     }
// }

// using UnityEngine;
// using System.Collections;

// public class WaveSpawner : MonoBehaviour
// {
//     public GameObject enemyPrefab;

//     public float spawnInterval = 2f;

//     public float minX = -8f;
//     public float maxX = 8f;
//     public float minY = -4f;
//     public float maxY = 4f;

//     void Start()
//     {
//         StartCoroutine(SpawnLoop());
//     }

//     IEnumerator SpawnLoop()
//     {
//         while (true)
//         {
//             SpawnEnemy();
//             yield return new WaitForSeconds(spawnInterval);
//         }
//     }

//     void SpawnEnemy()
//     {
//         Vector2 randomPosition = new Vector2(
//             Random.Range(minX, maxX),
//             Random.Range(minY, maxY)
//         );

//         Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
//     }
// }



// using UnityEngine;
// using System.Collections;

// public class WaveSpawner : MonoBehaviour
// {
//     public GameObject enemyPrefab;
//     public float spawnInterval = 5f;   // time between waves
//     public int enemiesPerWave = 3;     // number of enemies per side per wave
//     public float groundY = -2f;        // ground level Y position

//     void Start()
//     {
//         StartCoroutine(SpawnLoop());
//     }

//     IEnumerator SpawnLoop()
//     {
//         while (true)
//         {
//             SpawnWave();
//             yield return new WaitForSeconds(spawnInterval);
//         }
//     }

//     void SpawnWave()
//     {
//         // LEFT side spawns
//         for (int i = 0; i < enemiesPerWave; i++)
//         {
//             Vector2 leftSpawn = new Vector2(-9f, groundY);
//             Instantiate(enemyPrefab, leftSpawn, Quaternion.identity);
//         }

//         // RIGHT side spawns
//         for (int i = 0; i < enemiesPerWave; i++)
//         {
//             Vector2 rightSpawn = new Vector2(9f, groundY);
//             Instantiate(enemyPrefab, rightSpawn, Quaternion.identity);
//         }
//     }
// }


// using UnityEngine;
// using System.Collections;

// public class WaveSpawner : MonoBehaviour
// {
//     public GameObject enemyPrefab;
//     public float spawnInterval = 5f;   // time between waves
//     public int enemiesPerWave = 3;     // number of enemies per side per wave
//     public float groundY = -2f;        // ground level Y position

//     void Start()
//     {
//         StartCoroutine(SpawnLoop());
//     }

//     IEnumerator SpawnLoop()
//     {
//         while (true)
//         {
//             SpawnWave();
//             yield return new WaitForSeconds(spawnInterval);
//         }
//     }

//     void SpawnWave()
//     {
//         // LEFT side spawns
//         for (int i = 0; i < enemiesPerWave; i++)
//         {
//             Vector2 leftSpawn = new Vector2(-9f, groundY);
//             GameObject enemy = Instantiate(enemyPrefab, leftSpawn, Quaternion.identity);

//             // Ensure facing right
//             Vector3 scale = enemy.transform.localScale;
//             if (scale.x < 0) scale.x *= -1;
//             enemy.transform.localScale = scale;
//         }

//         // RIGHT side spawns
//         for (int i = 0; i < enemiesPerWave; i++)
//         {
//             Vector2 rightSpawn = new Vector2(9f, groundY);
//             GameObject enemy = Instantiate(enemyPrefab, rightSpawn, Quaternion.identity);

//             // Ensure facing left
//             Vector3 scale = enemy.transform.localScale;
//             if (scale.x > 0) scale.x *= -1;
//             enemy.transform.localScale = scale;
//         }
//     }
// }
// using UnityEngine;
// using System.Collections;

// public class WaveSpawner : MonoBehaviour
// {
//     public GameObject enemyPrefab;
//     public float spawnInterval = 5f;   // time between waves
//     public int enemiesPerWave = 3;     // number of enemies per side per wave
//     public float groundY = -2f;        // ground level Y position

//     void Start()
//     {
//         StartCoroutine(SpawnLoop());
//     }

//     IEnumerator SpawnLoop()
//     {
//         while (true)
//         {
//             SpawnWave();
//             yield return new WaitForSeconds(spawnInterval);
//         }
//     }

//     void SpawnWave()
//     {
//         // LEFT side spawns
//         for (int i = 0; i < enemiesPerWave; i++)
//         {
//             Vector2 leftSpawn = new Vector2(-9f, groundY);
//             GameObject enemy = Instantiate(enemyPrefab, leftSpawn, Quaternion.identity);

//             // Ensure facing right
//             Vector3 scale = enemy.transform.localScale;
//             if (scale.x < 0) scale.x *= -1;
//             enemy.transform.localScale = scale;
//         }

//         // RIGHT side spawns
//         for (int i = 0; i < enemiesPerWave; i++)
//         {
//             Vector2 rightSpawn = new Vector2(9f, groundY);
//             GameObject enemy = Instantiate(enemyPrefab, rightSpawn, Quaternion.identity);

//             // Ensure facing left
//             Vector3 scale = enemy.transform.localScale;
//             if (scale.x > 0) scale.x *= -1;
//             enemy.transform.localScale = scale;
//         }
//     }
// }

using UnityEngine;
using System.Collections;

public class wavespawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public int enemiesPerWave = 5;
    public float groundY = -2f;

    private int enemiesAlive;
    private int currentWave = 1;

    void Start()
    {
        StartCoroutine(WaveLoop());
    }

    IEnumerator WaveLoop()
    {
        while (true)
        {
            SpawnWave();

            // Wait until all enemies die
            yield return new WaitUntil(() => enemiesAlive <= 0);

            currentWave++;
            enemiesPerWave += 2; // optional difficulty scaling

            yield return new WaitForSeconds(2f);
        }
    }

    void SpawnWave()
    {
        enemiesAlive = enemiesPerWave;

        Debug.Log("Wave " + currentWave + " started with " + enemiesPerWave + " enemies.");

        for (int i = 0; i < enemiesPerWave; i++)
        {
            float xPos = (i % 2 == 0) ? -9f : 9f;
            Vector2 spawnPos = new Vector2(xPos, groundY);

                GameObject enemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

            // Subscribe to Damageable death event
            Damageable dmg = enemy.GetComponent<Damageable>();
            if (dmg != null)
            {
                dmg.onDeath += OnEnemyDeath;
            }
        }
    }

    void OnEnemyDeath()
    {
        enemiesAlive--; 
        Debug.Log("Enemy died. Remaining: " + enemiesAlive);
    }
}