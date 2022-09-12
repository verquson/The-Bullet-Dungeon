using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heals : MonoBehaviour

{  
    public int Healing;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<HealthAndArmor>())
        {
            collision.gameObject.GetComponent<HealthAndArmor>().AddHealth();
            Destroy(this.gameObject);
        }
        
    }
    
    

        void Update()
        {
            transform.Rotate(new Vector3(0, 0.3f, 0));
        }
    
}

