using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Fire : MonoBehaviour
{
    [SerializeField]private Animator animator;
    [SerializeField]private Transform firePoint;
    [SerializeField] private GameObject bulletprefab;
    [SerializeField] private float bulletForce = 20f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private AudioSource audioSource;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.Play();
            animator.SetTrigger("Fire");
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletprefab, firePoint.position, firePoint.rotation);
        Rigidbody2D bulletrb = bullet.GetComponent<Rigidbody2D>();
        bulletrb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
        
        Vector2 reactiveForce = -firePoint.right * bulletForce;
        rb.AddForce(reactiveForce, ForceMode2D.Impulse);
        Destroy(bullet, 1);
    }
}
