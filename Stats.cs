using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public float maxHp;
    public float moveSpeed;
    public float attackSpeed;

    private float currentHp;

    void Start()
    {
        currentHp = maxHp;
    }
    void Update()
    {
        if (currentHp < 0)
            //dead
            Destroy(this.gameObject); //temp

    }

    public void TakeDamage(float dmg)
    {
        currentHp = currentHp - dmg;
    }
    public void BeSlowed(float slowPercent)
    {
        if (slowPercent >1)
        {
            moveSpeed = 0;
        }
        else
            moveSpeed = moveSpeed * (1 - slowPercent);
    }
}
