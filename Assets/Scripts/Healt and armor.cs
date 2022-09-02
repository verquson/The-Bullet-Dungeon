using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Armor : MonoBehaviour
{
    public float health;
    public float armor;




    // Use this for initialization
    void Start()
    {
        health = 100f;
        armor = 20f;

    }

    // Update is called once per frame
    void Update()
    {

        Max_Min_Stats();

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