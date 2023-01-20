using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIgameOver : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;


    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }   

    void Start()
    {
        scoreText.text = scoreKeeper.getScore().ToString("00000000");
    }


}
