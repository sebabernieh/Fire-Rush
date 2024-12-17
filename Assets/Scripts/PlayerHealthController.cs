using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;


    private void Awake()
    {
        instance = this;
    }

    private int currentHealth;
    public int maxHealth;

    public float invincibilityLength = 1f;
    private float invincCounter;

    public GameObject[] modelDisplay;
    private float flashCounter;
    public float flashTime = .1f;

    // Start is called before the first frame update
    void Start()
    {
        FillHealth();
    }

    // Update is called once per frame
    void Update()
    {
        if(invincCounter > 0)
        {
            invincCounter -= Time.deltaTime;
            flashCounter -= Time.deltaTime;

            if (flashCounter <= 0)
            {
                flashCounter = flashTime;

                foreach (GameObject pice in modelDisplay)
                {
                    pice.SetActive(!pice.activeSelf);
                }
            }
            if (invincCounter <= 0)
            {
                foreach(GameObject pice in modelDisplay)
                {
                    pice.SetActive(true);
                }
            }
        }
    }

    public void DamagePlayer()
    {
        if(invincCounter <= 0)
        {
             invincCounter = invincibilityLength;
      
             currentHealth--;

            if (currentHealth <= 0)
            {
                LevelManager.instance.Respawn();
            } else
            {
                 AudioManger.instance.PlaySFX(12);
            }
            UIController.instance.UpdateHealthDisplay(currentHealth);
        }
    }

    public void FillHealth()
    {
        currentHealth = maxHealth;

        UIController.instance.UpdateHealthDisplay(currentHealth);
    }
}
