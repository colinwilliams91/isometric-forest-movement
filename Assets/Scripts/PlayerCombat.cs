using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

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
        animator.SetTrigger("Attack_Side");
        // Detect all enemies in range of attack

        // Apply damage to the enemies
    }
}
