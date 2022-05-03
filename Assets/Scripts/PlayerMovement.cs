using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Joystick joystick;
   
    [SerializeField] float moveSpeed = 3f;
    
    private Rigidbody2D rb;
    private Vector2 movement;

  

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = joystick.Horizontal;
        movement.y = -joystick.Vertical;
    }

    
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        CharacterRotation();
       
    }

    private void CharacterRotation()
    {
        if (movement.x > 0) rb.rotation = -90f;
        if (movement.x < 0) rb.rotation = 90f;
        if (movement.y > 0) rb.rotation = 0f;
        if (movement.y < 0) rb.rotation = -180f;
    }

}
