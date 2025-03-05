using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Sprite : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get input
        float moveX = Input.GetAxisRaw("Horizontal"); // A (-1) and D (+1)
        float moveY = Input.GetAxisRaw("Vertical");   // W (+1) and S (-1)
        
        // Store movement direction
        moveDirection = new Vector2(moveX, moveY).normalized;
    }
    void FixedUpdate()
    {
        // Apply movement
        rb.velocity = moveDirection * moveSpeed;
    }
}
