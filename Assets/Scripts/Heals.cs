using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heals : MonoBehaviour
    
{  
    public int Healing;


// Start is called before the first frame update
void Start()
    {

    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<HealthAndArmor>())
        {
            collision.gameObject.GetComponent<HealthAndArmor>().AddHealth();
        }
        Destroy(this.gameObject);
    }



}
