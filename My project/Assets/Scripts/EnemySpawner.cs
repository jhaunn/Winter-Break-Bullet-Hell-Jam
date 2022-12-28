using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;

    [SerializeField] private Vector2 minArea;
    [SerializeField] private Vector2 maxArea;

    [SerializeField] private int maxEnemies;
    private int currentEnemies;

    [SerializeField] private float spawnInterval;
    private float currentSpawnInterval;

    private void Start()
    {
        Instantiate(enemies[Random.Range(0, enemies.Length)], new Vector2(Random.Range(minArea.x, maxArea.x), Random.Range(minArea.y, maxArea.y)), Quaternion.identity);

        currentEnemies++;
        currentSpawnInterval = spawnInterval;
    }

    private void Update()
    {
        currentSpawnInterval -= Time.deltaTime;

        if (currentSpawnInterval <= 0f && currentEnemies < maxEnemies)
        {
            Instantiate(enemies[Random.Range(0, enemies.Length)], new Vector2(Random.Range(minArea.x, maxArea.x), Random.Range(minArea.y, maxArea.y)), Quaternion.identity);

            currentEnemies++;
            currentSpawnInterval = spawnInterval;
        }
    }
}
