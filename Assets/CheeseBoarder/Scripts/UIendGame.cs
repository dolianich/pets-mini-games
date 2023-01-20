using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIendGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counterText;
    CardCounts cardCounts;


    void Awake()
    {
        cardCounts = FindObjectOfType<CardCounts>();

    }

    void Start() 
    {
        counterText.text = cardCounts.GetNumber().ToString();

    }
}
