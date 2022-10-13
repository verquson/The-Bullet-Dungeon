using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.ComponentModel;

public class HealthAndArmor : MonoBehaviour
{
    public int maxHealth;
    public int maxArmor;
    int currentHealth;
    int currentArmor;
    //public TextMeshProUGUI armorText;
    //public TextMeshProUGUI healthText;

    void Start()
    {
        currentHealth = maxHealth;
        currentArmor = maxArmor;
    }
   
    private void Max_Min_Stats()
    {
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }

        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }

        if (currentArmor >= maxArmor)
        {
            currentArmor = maxArmor;
        }

        if (currentArmor <= 0)
        {
            currentArmor = 0;
        }
    }

    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(20);
        }
    }


    public void AddHealth()
    {
        currentHealth += 50;
    }

     public void TakeDamage(int amount)
    {
        //healthText.text = currentHealth.ToString();
        //armorText.text = currentArmor.ToString();

        Max_Min_Stats();



        currentArmor -= amount;
        if (currentArmor <= 0)
        {



            currentHealth -= amount;
            if (currentHealth <= 0)
            {
                Death();
            }
        }
    }


    
    private void Death()
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene("Mainmenu");
    }

}