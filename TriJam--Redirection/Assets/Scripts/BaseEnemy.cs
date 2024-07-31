using UnityEngine;

namespace DefaultNamespace
{
    public abstract class BaseEnemy: MonoBehaviour, IEnemy
    {
        private string Name;
        private Transform player; // Reference to the player's transform
        public float speed = 2f; // Speed at which the enemy moves
        public float rotationSpeed = 5f; // Speed at which the enemy rotates to face the player
        private Rigidbody2D rb; // Reference to the enemy's Rigidbody2D component



        public virtual void Initalize()
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            rb = GetComponent<Rigidbody2D>();
        }
        
        public void Update()
        {
            if (player != null && rb != null)
            {
                // Calculate the direction towards the player
                Vector2 direction = (player.position - transform.position).normalized;

                // Set the enemy's velocity towards the player
                rb.velocity = direction * speed;

                // Rotate the enemy to face the player smoothly
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle - 90)); // Adjust angle as needed
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }
        }
        }
    }