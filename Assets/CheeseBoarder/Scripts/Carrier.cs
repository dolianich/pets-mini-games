using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrier : MonoBehaviour

{
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] ParticleSystem collectedFX;

        void OnTriggerEnter2D(Collider2D other) 
        {
            if(other.tag == "Card") 
            {
                print("Card picked up");
                collectedFX.Play();
                Destroy(other.gameObject, destroyDelay);
            }

        }

}
