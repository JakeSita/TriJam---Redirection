using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

namespace DefaultNameSpace
{
    public class EnemySpeedUp : MonoBehaviour
    {
        public Timer timer { get; private set; }
        [SerializeField] private float speedUpTime = 6f;
        

        private void Start()
        {
            timer = new Timer(StaticGameManager.SpeedUp, speedUpTime, true);
            timer.StartTimer();
        }

        private void Update()
        {
            timer.Tick(Time.deltaTime);
        }
    }

}