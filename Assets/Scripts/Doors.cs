using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour

{
    public GameObject Boxprefab;
    //kun törmää objektiin niin toinen objekti hajoaa
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { 
            Destroy(Boxprefab);
            Destroy(this.gameObject);
        }
    }
}

