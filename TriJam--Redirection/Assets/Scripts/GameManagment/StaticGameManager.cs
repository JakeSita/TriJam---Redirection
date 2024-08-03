using System;
using UnityEngine;

namespace DefaultNamespace
{
    public static class StaticGameManager
    {
        public static Action<int> score;
        public static Action SpeedUp;
        public static int Actualscore = 0;
    }
}