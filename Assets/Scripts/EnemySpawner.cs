using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float initialSpawnRate;
    float spawnRate;

    private void Start()
    {
        spawnRate = initialSpawnRate;
    }
    void Update()
    {
        spawnRate -= 1f * Time.deltaTime;

        if (spawnRate <= 0)
        {
            Instantiate(enemyPrefab, transform.position, transform.rotation);
            spawnRate = initialSpawnRate;
        }


    }
}
