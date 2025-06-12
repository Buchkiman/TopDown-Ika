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
    [SerializeField] BoxCollider2D boxCollider2D;
    [SerializeField] SpriteRenderer spriteRendererBody;
    [SerializeField] SpriteRenderer spriteRendererTurret;
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
            DisableComponents();
            audioSource.PlayOneShot(destroyAudio);
            Destroy(gameObject, destroyAudio.length);
            score.IncreasPoints();
            
        }
    }

    private void DisableComponents()
    {
        enemy.enabled = false;
        boxCollider2D.enabled = false;
        spriteRendererBody.enabled = false;
        spriteRendererTurret.enabled = false;
    }


}
