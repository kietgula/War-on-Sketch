using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletDamage;
    public float bulletSpeed;
    public float bulletSlow;
    Stats st;
    Rigidbody2D rd;

    void Start()
    {
        rd = this.gameObject.GetComponent<Rigidbody2D>();
        rd.velocity = transform.right * bulletSpeed;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != this.gameObject.tag)
        {
            st = collision.gameObject.GetComponent<Stats>();
            st.TakeDamage(bulletDamage);
            st.BeSlowed(bulletSlow);
            Destroy(this.gameObject);
        }
    }
 
}
