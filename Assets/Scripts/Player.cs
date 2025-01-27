using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 9.5f;

    [SerializeField] Camera camera;

    [SerializeField] GameObject bulletPrefabs;

    [SerializeField] GameObject bulletSpawnPoint;

    void Update()
    {
        Move();
        Turn();

        if(Input.GetMouseButtonDown(0))
        {
            //Instantiate();

        }

        if (Input.GetMouseButtonDown(1))
        {
            //Instantiate();

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