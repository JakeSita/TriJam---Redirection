using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace DefaultNamespace
{
    public class BasicEnemy : BaseEnemy
    {
         public String Name = "BaseObject";

         public float _Speed  = 1f;

         public float _Multiplier  = 1f;
        
        
        public override void Initalize()
        {
            base.Initalize();
            
            //access baseClass variable
            speed = _Speed; 
            gameObject.name = Name;
            _multiplier = _Multiplier;
        }
        
        
    }

}