using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    // Amount of damage to deal to the player
    public int damageAmount = 1;

    // This function will be called when something enters the trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the object that entered the trigger is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Access the player's health script and reduce health
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
            }
        }
    }
}
