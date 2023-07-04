using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D character;

    public float jumpForce = 10f;
    public bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask ground;

    private void Awake()
    {
        character = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, ground);

        if (isGrounded && Input.GetButton("Jump"))
        {
            character.velocity = Vector2.up * jumpForce;
        }
    }
}
