using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{
    public GameObject gameManagerObj;
    public GameManager gameManager;
    private ParticleSystem jingle;
    void Start()
    {
        jingle = FindObjectOfType<ParticleSystem>();
        
        gameManagerObj = GameObject.Find("GameManager");
        if (gameManagerObj == null)
        {
            Debug.Log("Objeto no encontrado");
        }
        else
        {
            gameManager = gameManagerObj.GetComponent<GameManager>();
            gameManager.itemsOnLevel++;
            
        } 
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (gameManagerObj == null)
        {
            gameManager.itemsOnLevel--;
        }
        Score.ScoreNum += 1;
        jingle.transform.position = col.gameObject.transform.position;
        jingle.Play();
        Destroy((gameObject));
    }

    [SerializeField] private float speed;

    //Item Movement
    void Update()
    {
        gameObject.transform.position += Vector3.left * (Time.deltaTime * speed);
    }
}
