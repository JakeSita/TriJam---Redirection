using System;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Update = Unity.VisualScripting.Update;

namespace DefaultNamespace
{
    public class BlueDual : BaseEnemy
    {
        [SerializeField] public Stats _stats;

        public Stats.Enemystats stats
        {
            get => _stats.ScriptStats;
            set => _stats.ScriptStats = value;
        }

        public override void Initalize()
        {
            base.Initalize();
            speed = _stats.ScriptStats.Speed;
            gameObject.name = _stats.ScriptStats.Name;
            
        }
        
        
    }

}