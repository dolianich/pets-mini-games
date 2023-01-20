using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    [SerializeField] private GameObject enemyBullet;
    [SerializeField] private Transform attackPoint;
    public bool autoShoot = false;
    public float shootDelaySec = 0.05f;
    public float shootIntervalSec = 0.5f;
    float shootTimer = 0f;
    float delayTimer = 0f;

    public bool isActive = false;
    


  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(!isActive)
        {
            return;
        }
        if(autoShoot)
        {
            if(delayTimer >= shootDelaySec)
            {
                if(shootTimer >= shootIntervalSec) 
                {
                    Fire();
                    shootTimer = 0f;
                }
                else
                {
                    shootTimer += Time.deltaTime;
                }

            }
            else 
            {
                delayTimer += Time.deltaTime;
            }
        }
    }

    public void Fire()
    {
        Instantiate(enemyBullet, attackPoint.position, Quaternion.identity);
        
    }
}
