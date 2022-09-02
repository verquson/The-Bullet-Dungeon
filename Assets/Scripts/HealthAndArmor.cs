using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthAndArmor : MonoBehaviour
{
    public float health;
    public float armor;
   // public TextMeshProUGUI armorText;
   // public TextMeshProUGUI healthText;



    // Use this for initialization
    void Start()
    {
        health = 100f;
        armor = 20f;
    }

    // Update is called once per frame
    void Update()
    {


    }
   

    private void Max_Min_Stats()
    {
        if (health >= 100f)
        {
            health = 100f;
        }

        if (health <= 0f)
        {
            health = 0f;
        }

        if (armor >= 100f)
        {
            armor = 100f;
        }

        if (armor <= 0f)
        {
            armor = 0f;
        }
    }

     public void TakeDamage(float amount)
    {
        //healthText.text = health.ToString();
        //armorText.text = armor.ToString();

        Max_Min_Stats();

        

            armor -= amount;
        if (armor <= 0f)
        {

            

            health -= amount;
            if (health <= 0f)
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