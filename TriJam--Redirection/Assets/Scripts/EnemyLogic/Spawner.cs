using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    [RequireComponent(typeof(BasicEnemyFactory))]
    public class Spawner : MonoBehaviour
    {
        [Header("SpawnRate Settings")] public float initialSpawnRate = 2.0f;
        public float timeToDecreaseSpawnRate = 5.0f;
        public float spawnRateDecreaseAmount = 0.1f;
        public float minSpawnRate = 0.5f;
        private BasicEnemyFactory Factory;


        private void Start()
        {
            Factory = GetComponent<BasicEnemyFactory>();
            StartCoroutine(SpawnObjects());
            StartCoroutine(DecreaseSpawnRate());
        }

        IEnumerator SpawnObjects()
        {
            while (true)
            {
                yield return new WaitForSeconds(initialSpawnRate);
                Factory.GetEnemy();
            }
        }

        IEnumerator DecreaseSpawnRate()
        {
            while (true)
            {
                yield return new WaitForSeconds(timeToDecreaseSpawnRate);
                if (initialSpawnRate > minSpawnRate)
                    initialSpawnRate -= spawnRateDecreaseAmount;
            }
        }

    }
}
