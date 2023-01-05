using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 5f;

    public Rigidbody2D rigidBody;
    public Animator animator;

    Vector2 movement;


    void Update()
    {
        // Update for Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        // Fixed Update for Movement (Reliable for physics)
        rigidBody.MovePosition(rigidBody.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}
