using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro; 

public class Enemy : MonoBehaviour
{
    public int maxHealth = 3;
    public int xpValue = 1;
    private int currentHealth;
    [SerializeField] FloatingHealthBar healthBar;
    [SerializeField] private KillCounter killCounter;
    [SerializeField] private Player player;
    Rigidbody2D rb;
    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
        healthBar = GetComponentInChildren<FloatingHealthBar>();
        killCounter = FindObjectOfType<KillCounter>();
        player = FindObjectOfType<Player>();
        if (killCounter == null)
        {
            Debug.LogError("KillCounter not found in the scene! Make sure it's in the hierarchy.");
        }
    }
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.UpdateHealthBar(currentHealth,maxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(gameObject.name + " took damage! HP left: " + currentHealth);
        healthBar.UpdateHealthBar(currentHealth,maxHealth);
        if (currentHealth <= 0)
        {
            Die();
            player.addXP(xpValue);
        }
    }

    void Die()
    {
        if (killCounter != null)
        {
            killCounter.AddKill(); // Update kill counter
        }
        Debug.Log(gameObject.name + " has been destroyed!");
        Destroy(gameObject);
    }
}
