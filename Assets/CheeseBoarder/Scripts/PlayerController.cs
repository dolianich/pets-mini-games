using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float normalSpeed = 20f;
    [SerializeField] float boostSpeed = 30f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;
   

  

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
  {
    if(canMove)
    {
      RotatePLayer();
      RespondToBoost();
    }
  }

  public void DisableControls()
  {
    canMove = false; 
  }

  void RespondToBoost()
  {
    surfaceEffector2D.speed = boostSpeed;
    if(Keyboard.current.wKey.isPressed)
    {
        surfaceEffector2D.speed = boostSpeed;
    }
    else 
    {
        surfaceEffector2D.speed = normalSpeed;
    } 
  }

  void RotatePLayer()
  {
    if (Keyboard.current.aKey.isPressed)
    {
      rb2d.AddTorque(torqueAmount);
    }
    else if (Keyboard.current.dKey.isPressed)
    {
      rb2d.AddTorque(-torqueAmount);
    }
  }
}
