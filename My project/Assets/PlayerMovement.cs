using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.InputSystem;


public class UnityMonoBehaviour
{
}

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movementInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    [System.Obsolete]
    void Update()
    {
        // This is optional if you want smooth movement via physics
        rb.velocity = movementInput * moveSpeed;
    }

    // This is the method that receives input from the new Input System
    public void Move(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
   
    }
}