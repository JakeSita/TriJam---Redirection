using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    
    //public GameObject[] enemyPrefab;
    public float spawnRate = 5f;
    
    public BlueFactory BlueFactory;
    // Update is called once per frame
    private void Start()
    {
        BlueFactory = GetComponent<BlueFactory>();
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
        BlueFactory.GetEnemy();
       // int randomIndex = Random.Range(0, enemyPrefab.Length);
        //Instantiate(enemyPrefab[randomIndex], transform.position, Quaternion.identity);
    }
}
