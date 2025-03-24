using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    float spawnRate = 3f;

    void Update()
    {
        spawnRate -= 0.1f;

        if (spawnRate == 0)
        {
            Debug.Log(spawnRate);
            return;
        }


    }
}
