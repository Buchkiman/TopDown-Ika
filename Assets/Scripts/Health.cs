using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;
    Score score;


    private void Start()
    {
        score = GameObject.FindGameObjectWithTag("Scoreboard").GetComponent<Score>();
    }


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
            score.IncreasPoints();
        }
    }

}
