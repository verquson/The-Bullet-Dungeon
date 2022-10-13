using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heals : MonoBehaviour
    
{  
    //kerrotaan kuinka paljon halutaan antaa healingia
    public int Healing;

    //lis�� healthia pelaajalle kun siihen t�rm�t��n
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<HealthAndArmor>())
        {
            collision.gameObject.GetComponent<HealthAndArmor>().AddHealth();
            Destroy(this.gameObject);
        }
        
    }
    //pist�� heathpackit py�rim��n
    void Update()
    {
        transform.Rotate(0, 0.3f, 0);
    }


}
