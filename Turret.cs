using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Stats stats;
    private float nextDamageEvent;

    // Start is called before the first frame update
    void Start()
    {
        nextDamageEvent = Time.time;
    }

    void Update()
    {
        if (Time.time > nextDamageEvent)
        {

            Shoot();
            // 1/attackSpeed = attackDelay 
            nextDamageEvent = Time.time + 1 / stats.attackSpeed;
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

}
