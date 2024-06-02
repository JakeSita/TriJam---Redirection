using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    private int lives = 2;
    public GameObject[] hearts;
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if(lives <= 0)
            Destroy(this.gameObject);
        else
        {
            hearts[lives].SetActive(false);
            lives--;
        }
    }
    
}
