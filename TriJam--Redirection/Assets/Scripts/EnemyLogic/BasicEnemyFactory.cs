using UnityEngine;

namespace DefaultNamespace
{
    public class BasicEnemyFactory: BaseFactory
    {
        [SerializeField] GameObject _enemy;
        
        public override IEnemy GetEnemy()
        {
            GameObject newEnemy = Instantiate(_enemy, transform.position, Quaternion.identity);
            IEnemy Enemy = newEnemy.GetComponent<BasicEnemy>();
            Enemy.Initalize();
            
            return Enemy;
        }
    }
   
}