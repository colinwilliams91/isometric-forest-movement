using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public PlayerMovement playerMovement;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }    
    }

    // TODO: currently transitioning from ANY_State in animator
    // 3 different attack animations though, so they might need to be mapped?
    void Attack()
    {
        // Play an attack animation
        //animator.SetTrigger("Attack_Side");
        // Detect all enemies in range of attack

        // Apply damage to the enemies

        if (playerMovement.movement.x  > 0.1)
        {
            animator.SetTrigger("Attack_Right");
        }
        else if (playerMovement.movement.x < -0.1)
        {
            animator.SetTrigger("Attack_Left");
        }
        else if (playerMovement.movement.y > 0.1)
        {
            animator.SetTrigger("Attack_Back");
        }
        else if (playerMovement.movement.y < -0.1)
        {
            animator.SetTrigger("Attack_Front");
        }
        else
            animator.SetTrigger("Attack_Right");
    }
}
