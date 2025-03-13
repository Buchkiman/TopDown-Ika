using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int hitCount = 5;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        hitCount -= 1;


        if(collider.name == "Bullet(Clone)")
        {
            Destroy(collider.gameObject);
        }

        if (hitCount == 0)
        {
            Destroy(gameObject);
        }

        
    }
}
