using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.ComponentModel;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth;
    public int maxArmor;
    int curHealth;
    int curArmor;
    //public TextMeshProUGUI armorText;
    //public TextMeshProUGUI healthText;

    void Start()
    {
        curHealth = maxHealth;
        curArmor = maxArmor;
    }

    private void Max_Min_Stats()
    {
        if (curHealth >= maxHealth)
        {
            curHealth = maxHealth;
        }

        if (curHealth <= 0)
        {
            curHealth = 0;
        }

        if (curArmor >= maxArmor)
        {
            curArmor = maxArmor;
        }

        if (curArmor <= 0)
        {
            curArmor = 0;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(20);
        }
    }


   
    public void TakeDamage(int amount)
    {
        //healthText.text = currentHealth.ToString();
        //armorText.text = currentArmor.ToString();

        Max_Min_Stats();



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
