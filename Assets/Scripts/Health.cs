using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] AudioClip destroyAudio;
    [SerializeField] AudioSource audioSource;
    [SerializeField] Enemy enemy;
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
            audioSource.PlayOneShot(destroyAudio);
            Destroy(gameObject, destroyAudio.length);
            score.IncreasPoints();
            
        }
    }


}
