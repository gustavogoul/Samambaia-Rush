using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D character;

    public float jumpForce = 10f;
    public bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask ground;

    public GameObject gameOverScreen;
    public bool gameOver = false;
    public AudioSource jumpSound;

    private void Awake()
    {
        character = GetComponent<Rigidbody2D>();
        jumpSound = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, ground);

        if (isGrounded && Input.GetButton("Jump") && gameOver == false)
        {
            character.velocity = Vector2.up * jumpForce;
            jumpSound.Play();
        }
    }

    private void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "obstacle")
        {
            gameOverScreen.SetActive(true);
            gameOver = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene("LEVEL_01");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
