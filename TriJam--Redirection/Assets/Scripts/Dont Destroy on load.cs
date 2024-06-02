using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyonload : PersistentSingleton<DontDestroyonload>
{
    protected override void Awake()
    {
       base.Awake();
    }
}
