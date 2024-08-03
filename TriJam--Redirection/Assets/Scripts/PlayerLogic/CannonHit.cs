using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class CannonHit : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D other)
        {
            Destroy(this.gameObject);
            ;
        }
    }
}
