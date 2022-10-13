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
    { //asettaa alku healthit
        currentHealth = maxHealth;
        currentArmor = maxArmor;
    }
   
    private void Max_Min_Stats()
    {    // asettaa rajoja
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
    // törmäyksessä aiheuttaa damagea.
    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(20);
        }
    }

    //mahdollistaa lisä healthien saannin
    public void AddHealth()
    {
        currentHealth += 50;
    }
    //mahdollistaa damagen oton.
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


    //kuolemassa tuhoaa objektin ja heittää takaisin menuun.
    private void Death()
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene("init");
    }

}