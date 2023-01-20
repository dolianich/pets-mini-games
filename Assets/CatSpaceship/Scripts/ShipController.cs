using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    public float minY, maxY;
    public float minX, maxX;

    [SerializeField] private GameObject playerBullet;
    [SerializeField] private Transform attackPoint;
    public float attackTimer = 0.35f;
    public float currentAttackTimer;
    private bool canAttack;



    // Start is called before the first frame update
    void Start()
    {
        currentAttackTimer = attackTimer;
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveShipY();
        MoveShipX();
        Attack();
    }

    void MoveShipY()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            if(temp.y > maxY) temp.y = maxY;
            transform.position = temp;

        }
        else if (Keyboard.current.sKey.isPressed)
        {
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;
            if(temp.y < minY) temp.y = minY;
            transform.position = temp;

        }
    }

    void MoveShipX()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            if(temp.x > maxX) temp.x = maxX;
            transform.position = temp;

        }
        else if (Keyboard.current.aKey.isPressed)
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            if(temp.x < minX) temp.x = minX;
            transform.position = temp;

        }
    }

    void Attack()
    {
        attackTimer+= Time.deltaTime;
        if(attackTimer > currentAttackTimer)
        {
            canAttack = true;
        }

        if(Keyboard.current.cKey.isPressed)
        {
            if(canAttack)
            {
                canAttack = false;
                attackTimer = 0f;
                Instantiate(playerBullet, attackPoint.position, Quaternion.identity);
                //play soundFX
            }
        }

    }
}
