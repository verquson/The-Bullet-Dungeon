using UnityEngine;
using System.Collections;

public class SlowTime : MonoBehaviour
{
    //kerrotaan että kuinka paljon halut
    float currentAmount = 0f;
    public float maxAmount = 5f;

   

    // Update is called once per framew
    void Update()
    {
        //kun painaa spacea, aika hidastuu
        if (Input.GetKeyDown("space"))
        {

            if (Time.timeScale == 1.0f)
                Time.timeScale = 0.3f;

            else

                Time.timeScale = 1.0f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }


        if (Time.timeScale == 0.03f)
        {

            currentAmount += Time.deltaTime;
        }

        if (currentAmount > maxAmount)
        {

            currentAmount = 0f;
            Time.timeScale = 1.0f;

        }

    }
}
