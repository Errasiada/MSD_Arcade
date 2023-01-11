using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject swarmerPrefab;

    [SerializeField]
    private float swarmerInterval = 3.5f;

    private float[] positiony;
        
    void Start()
    {
        positiony = new[] { 1f, 3f, 5f };
        StartCoroutine(spawnEnemy(swarmerInterval, swarmerPrefab));

    }

 
    void Update()
    {
        
    }
//Spawner
    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(transform.position.x,positiony[Random.Range(0,positiony.Length)], 0),
            Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));

    }
}

