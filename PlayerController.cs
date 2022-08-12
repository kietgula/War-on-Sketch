using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;

    public KeyCode fire;
    public KeyCode placeTurret;

    public Stats stats;

    public GameObject bulletPrefab;
    public Transform firePoint;

    public GameObject turretPrefab;

    // Update is called once per frame
    void Update()
    {
        Move(Input.GetKey(up), Input.GetKey(down), Input.GetKey(left), Input.GetKey(right));
        Shoot(Input.GetKeyDown(fire));
        PlaceTurret(Input.GetKeyDown(placeTurret));
    }



    void Move(bool up, bool down, bool left, bool right)
    {
        Vector3 v = new Vector3(0, 0, 0);
        if (up == true)
            v.y = v.y + 1;
        if (down == true)
            v.y = v.y - 1;
        if (left == true)
            v.x = v.x - 1;
        if (right == true)
            v.x = v.x + 1;

        transform.Translate(v * stats.moveSpeed * Time.deltaTime);
    }

    void Shoot(bool key)
    {
        if (key == true)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);        
        }

    }    

    void PlaceTurret(bool key)
    {
        if (key == true)
        {
            Instantiate(turretPrefab, transform.position, transform.rotation);
        }
    }    

}
