using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class PlayerHit : MonoBehaviour
    {
        private int lives = 2;
        public GameObject[] hearts;
        public bool immune = false;
        private float immuneTime = 0f;
        public AudioSource hitSound;

        private DamageFlash damageFlash;


        private void Start()
        {
            damageFlash = GetComponent<DamageFlash>();
        }

        private void Update()
        {
            if (immune)
            {
                immuneTime += Time.deltaTime;
                if (immuneTime > 1f)
                {
                    immune = false;
                    immuneTime = 0f;
                }
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {

            if (lives <= 0 && other.gameObject.CompareTag("Enemy"))
            {
                hitSound.Play();
                Destroy(this.gameObject);
                hearts[lives].SetActive(false);
                SceneManager.LoadScene("EndGame");
            }
            else
            {
                if (!immune)
                {
                    hearts[lives].SetActive(false);
                    damageFlash.TriggerDamageFlash();
                    hitSound.Play();
                    lives--;
                    immune = true;
                }
            }
        }

    }
}
