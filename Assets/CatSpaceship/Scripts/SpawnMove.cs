using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMove : MonoBehaviour
{
    public float moveSp = 5f;
    float cosCenterY;
    public float amplitude = 1f;
    public float frequency = 2f;
    // Start is called before the first frame update
    void Start()
    {
        cosCenterY = transform.position.y;
    }

    private void FixedUpdate() 
    {
        Vector2 pos = transform.position;
        float cos = Mathf.Cos(pos.y * frequency) * amplitude;
        pos.y = cosCenterY + Time.deltaTime * cos;
        transform.position = pos;
    }
}
