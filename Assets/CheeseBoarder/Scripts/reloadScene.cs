using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reloadScene : MonoBehaviour
{
    CardCounts cardCounts;
    [SerializeField] float sceneDelay = 1f;


    void Awake ()
    {
        cardCounts = FindObjectOfType<CardCounts>();
    }
   
    public void ResetScene ()
    {
        cardCounts.ResetNumber();
        //SceneManager.LoadScene(1);
        StartCoroutine(Wait("Level1", sceneDelay));
    }

    IEnumerator Wait(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);

    }
}
