using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject[] enemyPrefab;
    public float spawnRate = 5f;
    // Update is called once per frame
    private void Start()
    {
       
        InvokeRepeating("SpawnEnemy", 6, spawnRate);
    }

    private void Update()
    {
       if (Time.deltaTime > 120f)
       {
           spawnRate /= 2;
       }
        
    }

    public void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, enemyPrefab.Length);
        Instantiate(enemyPrefab[randomIndex], transform.position, Quaternion.identity);
    }
}
