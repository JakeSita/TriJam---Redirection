using System;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Stats", menuName = "Stats/Stats")]
    
    public class Stats: ScriptableObject
    {
        
        [SerializeField] public Enemystats ScriptStats;
        
        
        [Serializable]
        public struct Enemystats
        {
            public String Name;
            public float Health;
            public float Damage;
            public float Speed;
            public float SpeedMultiplier;
        }
    }
}