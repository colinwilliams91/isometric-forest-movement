using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Enable collisions with objects/entities on the TileMap
// TODO: Prevent Player from resetting to facing "down" when movement stops
// TODO: Look into "Tile Rules"

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;
    PlayerFX playerFX;

    [Header("FX")]
    [SerializeField] ParticleSystem dust;

    //SpriteRenderer spriteRenderer;

    public void Awake()
    {
        playerFX = GetComponent<PlayerFX>();
    }

    public void Enter()
    {
        // kick up dust?
        // 1. dispatch event, let another object handle...
        // 2. 
    }

    // Update is called once per frame
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // to Flip walking animation Left (if x axis movement is negative) (instead of making flipped sprites, which is the better approach to use Blend Tree animator controll)
        //spriteRenderer.flipX = movement.x < 0.01 ? true : false;

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);


        // kick up dust...
        if (movement.x != 0 || movement.y != 0)
        {
            playerFX.KickupDust();
        }
    }

    // FixedUpdate doesn't change (like Update) so it is good for physics (reliable)
    void FixedUpdate()
    {
        // Movement (rb current position + movement * constant moveSpeed * amt of time elapsed since last fn call)
        // movement.normalized enforces constant speed over all 8 directions (diag too)
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}
