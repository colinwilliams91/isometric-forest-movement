using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    // FixedUpdate doesn't change (like Update) so it is good for physics (reliable)
    void FixedUpdate()
    {
        // Movement (rb current position + movement * constant moveSpeed * amt of time elapsed since last fn call)
        // movement.normalized enforces constant speed over all 8 directions (diag too)
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}
