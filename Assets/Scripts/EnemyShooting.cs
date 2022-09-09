using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    [SerializeField]
    private float minShootWaitTime = 1f, maxShootWaitTime = 3f;

    private float waitTime;

    private void Start()
    {
        waitTime = Time.time + Random.Range(minShootWaitTime, maxShootWaitTime);
    }

    private void Update()
    {

        if (Time.time > waitTime)
        {
            waitTime = Time.time + Random.Range(minShootWaitTime, maxShootWaitTime);
            Shoot();
        }

    }

    void Shoot()
    {
        GameObject EnemyBullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}

