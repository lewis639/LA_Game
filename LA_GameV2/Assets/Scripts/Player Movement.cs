using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
 
    private Rigidbody2D rb;
    
    private Animator _animator;

    private Vector2 _movementInput;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        SetAnimation();
    }


    private void SetAnimation()
    {
        bool IsWalkingUp = _movementInput != Vector2.zero;

        _animator.SetBool("IsWalkingUp", IsWalkingUp);

        bool IsWalkingDown = -_movementInput != Vector2.zero;

        _animator.SetBool("IsWalkingDown", IsWalkingDown);
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
 
    private void Update()
    {
        // Input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
 
        // Movement
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement * moveSpeed;
 
        // Optional: normalize movement to avoid faster diagonal movement
        // if (movement != Vector2.zero)
        //     rb.velocity = movement.normalized * moveSpeed;
        // else
        //     rb.velocity = Vector2.zero;
    }
}
