using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 9.5f;

    [SerializeField] Camera camera;

    [SerializeField] GameObject bulletPrefabs;

    [SerializeField] GameObject ghostBullet;

    [SerializeField] GameObject bulletSpawnPoint;

    [SerializeField] float bulletFireRateDefault = 1f;

    [SerializeField] float ghostBulletFireRateDefault = 2f;

    float bulletFireRate;
    float ghostBulletFireRate;

    private void Start()
    {
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
            Instantiate(bulletPrefabs, bulletSpawnPoint.transform.position, transform.rotation);
            bulletFireRate = bulletFireRateDefault;
        }

       

        if (ghostBulletFireRate <= 0 && Input.GetMouseButtonDown(1))
        {
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
}