using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    

    public void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 8000);
    }

   
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
