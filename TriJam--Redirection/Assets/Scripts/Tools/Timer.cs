using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Timer
    {
        private float time;
        private bool isRunning;
        public Action OnTimerTrigger { get; }
        private float duration;
        private bool repeat;


        public Timer(Action a, float duration)
        {
            OnTimerTrigger = a;
            isRunning = false;
            this.duration = duration;
        }

        public Timer(Action a, float duration, bool repeat)
        {
            OnTimerTrigger = a;
            isRunning = false;
            this.duration = duration;
            this.repeat = repeat;
        }

        public float GetTime()
        {
            return time;
        }

        public void StartTimer()
        {
            isRunning = true;
        }

        public void StopTimer()
        {
            isRunning = false;
        }

        public void Tick(float time)
        {
            if (isRunning)
            {
                this.time += time;
                if (this.time >= duration)
                {
                    OnTimerTrigger?.Invoke();
                    if (!repeat)
                        isRunning = false;
                    this.time = 0;
                }
            }
        }
    }
}
