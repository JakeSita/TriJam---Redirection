using System;
using UnityEngine;

namespace DefaultNamespace
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class BaseEnemy: MonoBehaviour, IEnemy
    {
        private Transform player; // Reference to the player's transform
        
        
        [HideInInspector]
        public float speed = 2f; // Speed at which the enemy moves
        [HideInInspector]
        public float _multiplier = 1f;
        
        
        protected float rotationSpeed = 5f; // Speed at which the enemy rotates to face the player
        
        private Rigidbody2D rb; // Reference to the enemy's Rigidbody2D component
        
        
        
        private void OnEnable()
        {
            StaticGameManager.SpeedUp += SetSpeed;
        }

        private void OnDisable()
        {
            StaticGameManager.SpeedUp -= SetSpeed;
        }

        public virtual void Initalize()
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            rb = GetComponent<Rigidbody2D>();
        }

        private void SetSpeed()
        {
            speed *= _multiplier;
        }

        public virtual void Update()
        {
            if (player != null && rb != null)
            {
                if (rb.bodyType == RigidbodyType2D.Dynamic)
                {
                    // Calculate the direction towards the player
                    Vector2 direction = (player.position - transform.position).normalized;

                    // Set the enemy's velocity towards the player
                    rb.velocity = direction * speed;

                    // Rotate the enemy to face the player smoothly
                    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                    Quaternion targetRotation =
                        Quaternion.Euler(new Vector3(0, 0, angle - 90)); // Adjust angle as needed
                    transform.rotation =
                        Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
                }
            }
        }
        }
    }