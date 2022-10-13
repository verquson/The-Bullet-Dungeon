using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public BulletData data;
    private Object gameobject;
    

    public void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 7000);
    }


    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<HealthAndArmor>())
        {
            collision.gameObject.GetComponent<HealthAndArmor>().TakeDamage(data.BulletDamage);
        }
        Destroy(this.gameObject);

    }
    public void OnCollisionEnter1(Collision collision)
    {

        if (collision.gameObject.GetComponent<EnemyHealth>())
        {
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(data.BulletDamage);
        }
        Destroy(this.gameObject);

    }
}
