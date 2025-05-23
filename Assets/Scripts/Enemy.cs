using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] float speed = 2f;
    [SerializeField] int damage = 100;
    Transform player;

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;

    }
    void Update()
    {
        if(player == null)
        {
            return;
        }
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

 
    public int GetDamage()
    {
        return damage;
    }

}
