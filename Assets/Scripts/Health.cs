using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        health -= 50;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
