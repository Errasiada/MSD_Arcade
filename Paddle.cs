using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
   
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    private GameManager gameManager;
    private int jumpCount = 0;
    public int Health => health;

    [SerializeField] private int move;
    public int health;
    [SerializeField] private GameObject canvas;
    
    
    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        
    }
    
    void Update()
    {
        if (health < 0)
        {
            canvas.SetActive(true);
            Destroy(gameObject);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * (move * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * (move * Time.deltaTime));
        }
        //JUMP
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (jumpCount < 2)
            {
                float jumpVelocity = 10f;
                rigidbody2d.velocity = Vector2.up * jumpVelocity;
                jumpCount += 1;
            }
            
        }
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Bird"))
        {
            
            health -= 1;
            Debug.Log("You were hit by an enemy");
            if (gameManager != null)
            {
                gameManager.PlayerLives--;
            }
            Destroy(col.gameObject);
        }

        if (col.transform.CompareTag("Floor"))
        {
            jumpCount = 0;
            
        }
    }
}
       
    

        



