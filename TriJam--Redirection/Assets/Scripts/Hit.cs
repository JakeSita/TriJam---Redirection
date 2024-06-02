using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    private Animator anime;
    private Rigidbody2D rb;

    private void Start()
    {
        anime = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
            anime.SetTrigger("Dead");
            rb.bodyType = RigidbodyType2D.Static;
            Destroy(this.gameObject, .8f);
            
        
    }
}
