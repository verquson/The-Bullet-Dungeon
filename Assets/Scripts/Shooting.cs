using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    bool fireOnCD = false;
    public float fireRate = .1f;

    void Update()
    {
        if (Input.GetButton("Fire1") && !fireOnCD)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject Bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        fireOnCD = true;
        Invoke("ResetFireCD", fireRate);
    }

    void ResetFireCD()
    {
        fireOnCD = false;
    }


    void Start()
    {
 
        
    }
}