using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBirdyFish : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 2;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // Jump Birdy Fish
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
