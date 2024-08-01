using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [Header("SpawnRate Settings")] 
    public float initialSpawnRate = 2.0f;
    public float timeToDecreaseSpawnRate = 5.0f;
    public float spawnRateDecreaseAmount = 0.1f;
    public float minSpawnRate = 0.5f;
    [Header("enemy Speed Up Settings")]
    public float SpeedUpAmount = 2.0f;
    public float speedUpRate = 0.5f;
    public float SpeedUpMultiplier = 1f;
    private BlueFactory BlueFactory;

    private void Start()
    {
        BlueFactory = GetComponent<BlueFactory>();
        StartCoroutine(SpawnObjects());
        StartCoroutine(DecreaseSpawnRate());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            yield return new WaitForSeconds(initialSpawnRate);
            IEnemy enemy = BlueFactory.GetEnemy();
            if (initialSpawnRate < speedUpRate)
            {
                enemy.SetSpeed(SpeedUpAmount * SpeedUpMultiplier);
            }

        }
    }
    
    
    IEnumerator DecreaseSpawnRate()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToDecreaseSpawnRate);
            if(initialSpawnRate > minSpawnRate)
                initialSpawnRate -= spawnRateDecreaseAmount;
        }
    }

}
