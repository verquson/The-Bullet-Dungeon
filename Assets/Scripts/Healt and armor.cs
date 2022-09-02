using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Armor : MonoBehaviour
{
    public float health;
    public float armor;
    public GUIText armorText;
    public GUIText healthText;



    // Use this for initialization
    void Start()
    {
        health = 100f;
        armor = 20f;
        healthText = healthText.GetComponent<GUIText>();
        armorText = armorText.GetComponent<GUIText>();
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
        healthText.text = health.ToString();
        armorText.text = health.ToString();

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
        Destroy(gameObject);
    }

}