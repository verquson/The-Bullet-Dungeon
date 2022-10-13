using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewBulletData", menuName = "AUD/Create New Bullet Data", order = 0)]
public class BulletData : ScriptableObject
{
    //annetaan luodille vahinko,nopeus ja luodin muut tiedot
    public GameObject bulletPrefab;
    public string BulletName;
    public int BulletDamage = 5;
    public float fireRate = .1f;
}
