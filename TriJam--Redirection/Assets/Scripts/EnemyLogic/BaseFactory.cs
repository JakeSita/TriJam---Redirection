using UnityEngine;

namespace DefaultNamespace
{
    public abstract class BaseFactory: MonoBehaviour
    {
        public abstract IEnemy GetEnemy();
    }
}