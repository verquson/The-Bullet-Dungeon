using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Object gameobject;
    public GameObject Particle;

    public void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 7000);
    }

    private void OnCollisionEnter(Collision other)
    {
        
           Destroy (this.gameObject);     
    }

}
