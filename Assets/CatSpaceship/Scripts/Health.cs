using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    bool canBeDestroyed = false;
    [SerializeField] bool isPLayer;
    [SerializeField] int health = 50;
    [SerializeField] int score = 50;
    [SerializeField] ParticleSystem hitEffect;

    [SerializeField] bool applyCameraShake;
    CameraShake cameraShake;

    ScoreKeeper scoreKeeper;
    LvLmanager levelManager;

    void Awake()
    {
        cameraShake = Camera.main.GetComponent<CameraShake>();

        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        levelManager = FindObjectOfType<LvLmanager>();
    }


    void Start() 
    {

    }
    void Update() 
    {
        if(transform.position.x < 7.5f && !canBeDestroyed)
        {
            canBeDestroyed = true;
            gun[] guns = transform.GetComponentsInChildren<gun>();
            foreach (gun gg in guns )
            {
                gg.isActive = true;
            }
        }
        if(transform.position.x < -10f)
        {
           Destroy(gameObject);
        }


        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(!canBeDestroyed)
        {
            return;
        }
        Damage damage = other.GetComponent<Damage>();


        if(damage != null )
        {
            TakeDamage(damage.GetDamage());
            PlayHitEffect();
            ShakeCamera();
            damage.Hit();
        }

    }

    public int GetHealth()
    {
        return health;

    }

    void TakeDamage(int damageXP)
    {
        health -= damageXP;
        if(health <= 0)
        {
            Die();
        }

    }

    void Die() 
    {
        if(!isPLayer)
        {
            scoreKeeper.ModifyScore(score);
        }
        else
        {
            levelManager.LoadGameOver();
        }
        Destroy(gameObject);
    }

    void PlayHitEffect()
    {
        if(hitEffect != null)
        {
            ParticleSystem instance = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(instance.gameObject, instance.main.duration + instance.main.startLifetime.constantMax);
        }
    }

    void ShakeCamera()
    {
        if(cameraShake != null && applyCameraShake)
        {
            cameraShake.Play();
        }
    }

   
}
