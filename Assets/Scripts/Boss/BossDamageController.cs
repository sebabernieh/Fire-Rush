using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDamageController : MonoBehaviour
{
    public BossBattleController bossCon; // Reference to the boss controller
    private PlayerController player;     // Reference to the player controller

    private void Start()
    { 
        // Find the PlayerController in the scene
        player = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player enters the boss's damage area
        if (other.tag == "Player")
        {
            bossCon.DamageBoss();  // Reduce boss's health
            player.Bounce();       // Make the player bounce
        }
    }
}
