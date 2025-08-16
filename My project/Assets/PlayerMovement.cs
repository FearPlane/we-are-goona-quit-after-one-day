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
    private Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
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
        animator.SetBool("isWalking", true);
        if (context.canceled)
        {
            animator.SetBool("isWalking", false);
            animator.SetFloat("LastInputX",movementInput.x);
            animator.SetFloat("LastInputY",movementInput.y);
        }

    movementInput = context.ReadValue<Vector2>();
        animator.SetFloat("InputX", movementInput.x);
        animator.SetFloat("InputY", movementInput.y);
    }
}