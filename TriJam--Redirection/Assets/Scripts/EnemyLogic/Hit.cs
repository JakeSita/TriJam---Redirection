using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace DefaultNamespace
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(CircleCollider2D))]
    public class Hit : MonoBehaviour
    {
        private Animator anime;
        private Rigidbody2D rb;
        private CircleCollider2D circleCollider2D;
        public AudioSource audioSource;

        private void Start()
        {
            anime = GetComponent<Animator>();
            rb = GetComponent<Rigidbody2D>();
            circleCollider2D = GetComponent<CircleCollider2D>();

        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Bullet"))
            {
                circleCollider2D.enabled = false;
                audioSource.Play();
                StaticGameManager.score(10);
                anime.SetTrigger("Dead");
                rb.bodyType = RigidbodyType2D.Static;
                Destroy(this.gameObject, .8f);
            }

            if (other.gameObject.CompareTag("Player"))
            {
                anime.SetTrigger("Dead");
                rb.bodyType = RigidbodyType2D.Static;
                Destroy(this.gameObject, .8f);
            }


        }
    }
}