using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject Bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
       
    }

 
   

    void Start()
    {
 
        
    }
}