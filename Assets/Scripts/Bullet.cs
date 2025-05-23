using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] Rigidbody2D rb;
    [SerializeField] float bulletspeed = 20f;
    [SerializeField] int damage = 10;
    [SerializeField] bool destroyOnContact;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(transform.up *bulletspeed, ForceMode2D.Impulse);
        Destroy(gameObject, 1.5f);
    }

    public int GetDamage()
    {
        return damage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(destroyOnContact)
        {
            Destroy(gameObject);
        }
    }
}
