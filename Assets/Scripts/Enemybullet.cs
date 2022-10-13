using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemybullet : MonoBehaviour
{
    //otetaan luodin scriptable objectin data ja objekti luodille
    public BulletData data;
    private Object gameobject;

    //antaa luodille voimaa mennä eteenpäin
    public void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 7000);
    }

    //jos luoti osuu viholliseen, se etsii vihollisen healtscriptin ja ottaa vahinkoa
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<EnemyHealth>())
        {
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamag(data.BulletDamage);
        }
        Destroy(this.gameObject);

    }
}
