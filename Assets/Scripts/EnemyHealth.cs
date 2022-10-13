using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.ComponentModel;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealt;
    public int maxArmour;
    int curHealth;
    int curArmor;
    //public TextMeshProUGUI armorText;
    //public TextMeshProUGUI healthText;

    void Start()
    {
        curHealth = maxHealt;
        curArmor = maxArmour;
    }

    private void Max_MinStats()
    {
        if (curHealth >= maxHealt)
        {
            curHealth = maxHealt;
        }

        if (curHealth <= 0)
        {
            curHealth = 0;
        }

        if (curArmor >= maxArmour)
        {
            curArmor = maxArmour;
        }

        if (curArmor <= 0)
        {
            curArmor = 0;
        }
    }

    void OnCollisionEnte(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamag(20);
        }
    }


   
    public void TakeDamag(int amount)
    {
        //healthText.text = currentHealth.ToString();
        //armorText.text = currentArmor.ToString();

        Max_MinStats();



        curArmor -= amount;
        if (curArmor <= 0)
        {



            curHealth -= amount;
            if (curHealth <= 0)
            {
                Dead();
            }
        }
    }



    private void Dead()
    {
        Destroy(this.gameObject);
    }

}
