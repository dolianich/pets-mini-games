using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickedUp : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] ParticleSystem collectedFX;
    [SerializeField] ParticleSystem sprinklesFX;
    [SerializeField] int number = 0;

    CardCounts cardCounts;
    public float cards = 0;
    public TextMeshProUGUI textCards;

   

    void Awake() 
    {
        cardCounts = FindObjectOfType<CardCounts>();
    }

    void OnTriggerEnter2D(Collider2D collider) 

    {
        if(collider.transform.tag == "Card")
        {
            print("picked up");
            //cards++;
            //textCards.text = cards.ToString();
            cardCounts.ModifyCounts(number);
            collectedFX.Play();
            sprinklesFX.Play();
            Destroy(collider.gameObject, destroyDelay);
        }
    }
}
