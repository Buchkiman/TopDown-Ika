using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 9.5f;

    [SerializeField] Camera camera;
    [SerializeField] private int health;
    [SerializeField] TextMeshProUGUI healthText;

    [SerializeField] GameObject bulletPrefabs;

    [SerializeField] GameObject ghostBullet;

    [SerializeField] GameObject bulletSpawnPoint;

    [SerializeField] float bulletFireRateDefault = 1f;

    [SerializeField] float ghostBulletFireRateDefault = 2f;

    [SerializeField] SceneLoader sceneLoader;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip lossSound;
    [SerializeField] AudioClip bulletSound;
    [SerializeField] AudioClip ghostBulletSound;

    [SerializeField] Player player;
    [SerializeField] BoxCollider2D boxCollider2D;
    [SerializeField] SpriteRenderer spriteRendererBody;
    [SerializeField] SpriteRenderer spriteRendererTurret;

    float bulletFireRate;
    float ghostBulletFireRate;

    private void Start()
    {
        healthText.text = "Health: " + health;
        bulletFireRate = bulletFireRateDefault;
        ghostBulletFireRate = ghostBulletFireRateDefault;
    }

    void Update()
    {
        Move();
        Turn();

        bulletFireRate -= Time.deltaTime;
        ghostBulletFireRate -= Time.deltaTime;

        if (bulletFireRate <= 0 && Input.GetMouseButtonDown(0))
        {
            audioSource.PlayOneShot(bulletSound);
            Instantiate(bulletPrefabs, bulletSpawnPoint.transform.position, transform.rotation);
            bulletFireRate = bulletFireRateDefault;
        }

       

        if (ghostBulletFireRate <= 0 && Input.GetMouseButtonDown(1))
        {
            audioSource.PlayOneShot(ghostBulletSound);
            Instantiate(ghostBullet, bulletSpawnPoint.transform.position, transform.rotation);
            ghostBulletFireRate = ghostBulletFireRateDefault;
        }

    }


    void Turn()
    {
        Vector2 mouseWorldPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDirection = mouseWorldPosition - (Vector2)transform.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        transform.position = transform.position + new Vector3(horizontal, vertical) * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        
        if(enemy)
        {
            health -= enemy.GetDamage();
            healthText.text = "Health: " + health; 
        }

        if(health <= 0)
        {
            DisableComponents();
            audioSource.PlayOneShot(lossSound);
            sceneLoader.LoadGameOverUI();
            Destroy(gameObject, lossSound.length);
        }
    }

    private void DisableComponents()
    {
        player.enabled = false;
        boxCollider2D.enabled = false;
        spriteRendererBody.enabled = false;
        spriteRendererTurret.enabled = false;
    }

}