using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    float spawnRate = 2.5f;

    void Update()
    {
        spawnRate -= 1f * Time.deltaTime;

        if (spawnRate <= 0)
        {
            Debug.Log("enemy spawned");
            spawnRate = 2.5f;
        }


    }
}
