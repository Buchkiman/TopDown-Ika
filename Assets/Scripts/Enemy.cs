using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int hitCount = 3;
    private void OnTriggerEnter2D(Collider2D col)
    {



        //Destroy(gameObject);
        //Destroy(col.gameObject);
    }
}
