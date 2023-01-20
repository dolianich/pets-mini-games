using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIcounter : MonoBehaviour
{
    [Header("Counter")] 
    [SerializeField] TextMeshProUGUI counterText;

    CardCounts cardCounts;

    void Awake()
    {
        cardCounts = FindObjectOfType<CardCounts>();
    }

    void Update()
    {
        counterText.text = cardCounts.GetNumber().ToString();

    }


    
}
