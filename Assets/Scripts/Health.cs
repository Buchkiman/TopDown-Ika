using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Bullet bullet = collision.GetComponent<Bullet>();

        if(bullet)
        {
            health -= bullet.GetDamage();
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
