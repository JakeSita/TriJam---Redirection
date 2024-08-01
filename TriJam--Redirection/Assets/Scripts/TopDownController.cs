using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class TopDownController : MonoBehaviour
{

    private Transform playerSprite;
    private Vector2 mouseposition;
    [SerializeField]private Camera cam;
    private float RotationSpeed = 5.0f;
    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseposition = cam.ScreenToWorldPoint(Input.mousePosition);
        playerSprite.localScale = mouseposition.x > rb.position.x ? new Vector3(1, 1, 1) : new Vector3(1, -1, 1);
    }

    private void FixedUpdate()
    {
        Vector2 lookDir = mouseposition - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }
}
