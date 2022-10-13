using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemybullet : MonoBehaviour
{
    public BulletData data;
    private Object gameobject;


    public void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 7000);
    }


    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<EnemyHealth>())
        {
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamag(data.BulletDamage);
        }
        Destroy(this.gameObject);

    }
}
