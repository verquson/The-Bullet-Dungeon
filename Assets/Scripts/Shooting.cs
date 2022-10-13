using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public BulletData shotData;
    public Transform firePoint;
    public Transform secondaryFirePoint;
    public GameObject bulletPrefab;
    bool fireOnCD = false;
    

    void Update()
    {   //mahdollistaa ampumisen
        if (Input.GetButton("Fire1") && !fireOnCD)
        {
            
            Shoot();
        }
    }
    public void Shoot()
    {    //antaa luodeille arvoja ja mahdollistaa toisen aseen käytön.
        GameObject Bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        GameObject SecondaryBullet = Instantiate(bulletPrefab, secondaryFirePoint.position, secondaryFirePoint.rotation);
        fireOnCD = true;
        Invoke("ResetFireCD",shotData.fireRate);
    }

    void ResetFireCD()
    {    //cooldown
        fireOnCD = false;
    }
}