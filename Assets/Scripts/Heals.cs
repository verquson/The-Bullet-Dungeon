using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heals : MonoBehaviour
    
{  
    //kerrotaan kuinka paljon halutaan antaa healingia
    public int Healing;

    //lisää healthia pelaajalle kun siihen törmätään
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<HealthAndArmor>())
        {
            collision.gameObject.GetComponent<HealthAndArmor>().AddHealth();
            Destroy(this.gameObject);
        }
        
    }
    //pistää heathpackit pyörimään
    void Update()
    {
        transform.Rotate(0, 0.3f, 0);
    }


}
