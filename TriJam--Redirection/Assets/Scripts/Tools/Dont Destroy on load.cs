using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class DontDestroyonload : PersistentSingleton<DontDestroyonload>
    {
        protected override void Awake()
        {
            base.Awake();
        }
    }
}
