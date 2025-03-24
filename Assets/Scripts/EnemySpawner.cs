using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] GameObject enemyPrefab;
    float spawnRate = 2.5f;

    void Update()
    {
        spawnRate -= 1f * Time.deltaTime;

        if (spawnRate <= 0)
        {
            Instantiate(enemyPrefab, transform.position, transform.rotation);
            spawnRate = 2.5f;
        }


    }
}
