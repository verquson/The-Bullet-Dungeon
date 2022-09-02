using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
   
    public int collisonDamage = 1;
    void Update()
    {

        if (collision.gameobject.tag == "Player")
        {
            if (Health.armor > 0)
            {
                Health.armor -= collisonDamage;
            }
            else
            {
                Health.health -= collisonDamage;
            }
        }

    }

   
}
