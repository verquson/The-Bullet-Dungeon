using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //otetaan luodin scriptable objectin data ja objekti luodille
    public BulletData data;
    private Object gameobject;
    
    //antaa luodille voimaa mennä eteenpäin
    public void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 7000);
    }

    //jos luoti osuu pelaajaan, se etsii healtscriptin ja ottaa vahinkoa
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<HealthAndArmor>())
        {
            collision.gameObject.GetComponent<HealthAndArmor>().TakeDamage(data.BulletDamage);
        }
        Destroy(this.gameObject);

    }

}
