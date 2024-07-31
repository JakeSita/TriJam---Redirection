using UnityEngine;

namespace DefaultNamespace
{
    public class BlueFactory: BaseFactory
    {
        [SerializeField] GameObject _enemy;
        
        public override IEnemy GetEnemy()
        {
            GameObject newEnemy = Instantiate(_enemy, transform.position, Quaternion.identity);
            IEnemy Enemy = newEnemy.GetComponent<BlueDual>();
            Enemy.Initalize();
            
            return Enemy;
        }
    }
   
}