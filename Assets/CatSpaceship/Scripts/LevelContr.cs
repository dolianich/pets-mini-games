using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelContr : MonoBehaviour
{
    public static LevelContr instance;
    int numEnemies = 0;
    bool startNextLevel = false;

    string[] levels = {"Lvl1", "Lvl2"};
    int currentLevel = 1;

    public float nextLevelTimer = 3;

    // Start is called before the first frame update

    private void Awake() 
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(startNextLevel)
        {
            if(nextLevelTimer <= 0)
            {
                currentLevel++;
                if(currentLevel <= levels.Length)
                {
                    string sceneName = levels[currentLevel - 1];
                    SceneManager.LoadSceneAsync(sceneName);

                }
                else
                {
                    Debug.Log("GAMEOVER!");
                }
                nextLevelTimer = 3;
                startNextLevel = false;

            }
            else
            {
                nextLevelTimer -= Time.deltaTime;

            }
        }
        
    }
    
    public void AddEnemy()
    {
        numEnemies++;
    }

    public void RemoveEnemy()
    {
        numEnemies--;

        if(numEnemies == 0)
        {
            startNextLevel = true;

        }
    }
}
