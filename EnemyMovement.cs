using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] private float speed;
    
    //Enemy Movement
    void Update()
    {
        gameObject.transform.position += Vector3.left * (Time.deltaTime * speed);
        
    }
}
