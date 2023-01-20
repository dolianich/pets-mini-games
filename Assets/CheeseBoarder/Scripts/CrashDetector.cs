using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    //[SerializeField] float reloadTime = 0.6f;
    [SerializeField] ParticleSystem DeadEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;
    reloadScene resetScene;

    void Awake()
    {
        resetScene = FindObjectOfType<reloadScene>();
    }


    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            DeadEffect.Play();
            //GetComponent<AudioSource>().PlayOneShot(crashSFX);
            //Invoke("ReloadScene", reloadTime);
            resetScene.ResetScene();
        }    
    }
}
