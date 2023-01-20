using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() 
    {
        Vector2 pos = transform.position;
        pos.x -= moveSpeed * Time.deltaTime;

        transform.position = pos;
        
    }
}
