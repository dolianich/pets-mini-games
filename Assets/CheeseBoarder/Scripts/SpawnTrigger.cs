using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    public Spawner spawner;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("CheeseTrig")) 
        {
            spawner.SpawnObject();
        }
    }
}