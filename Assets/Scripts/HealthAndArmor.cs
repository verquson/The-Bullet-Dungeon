using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthAndArmor : MonoBehaviour
{
    public int maxHealth;
    public int maxArmor;
    int currentHealth;
    int currentArmor;
    //public TextMeshProUGUI armorText;
    //public TextMeshProUGUI healthText;



    // Use this for initialization
    void Start()
    {
       //currentHealth = maxHealth;
        currentArmor = maxArmor;
    }

    // Update is called once per frame
    void Update()
    {


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

    public void AddHealth()
    {
        currentHealth += 10;
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
    }

}