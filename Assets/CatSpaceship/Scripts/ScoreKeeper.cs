using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int score;
    static ScoreKeeper instance;


    void Awake()
    {
        ManageSingleton();
    }

    void ManageSingleton()
    {
        if(instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }

        else 
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public int getScore()
    {
        return score;
    }

    public void ModifyScore(int value)
    {
        score += 100 * value;
        Mathf.Clamp(score, 0, int.MaxValue);

    }

    public void ResetScore()
    {
        score = 0;
    }

}
