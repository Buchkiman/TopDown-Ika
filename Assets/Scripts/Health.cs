using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]float health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        health -= 10;
        Debug.Log(health);


        Bullet bullet = collision.GetComponent<Bullet>();
        Debug.Log(collision.name);

        if(bullet)
        {
            health -= bullet.GetlDamage();
        }

            //if (health <= 0)
            //{
            //    Destroy(gameObject);
            //}

    }
}
