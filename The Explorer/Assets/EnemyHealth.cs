using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Animator Enemy;
    public int MaxHealth = 6;
    int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = MaxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        //play damage animation
        Enemy.SetTrigger("Damage");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("The enemy has died");
        Enemy.SetBool("IsDead", true);
        
        GetComponent<Collider>().enabled = false;
        this.enabled = false;

        //Add points to the score
        Score.instance.AddPoint();

        Destroy (gameObject);
    }
}


