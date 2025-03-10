using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int hitCount = 5;

    private void OnTriggerEnter2D(Collider2D col)
    {
        hitCount -= 1;

        Destroy(col.gameObject);

        if (hitCount == 0)
        {
            Destroy(gameObject);
        }

        void OnCollisionEnter3D(Collision2D col)
        {
            Destroy(col.gameObject);
        }
        
    }
}
