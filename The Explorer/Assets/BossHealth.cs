using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    public Animator Boss;
    public int MaxHealth = 6;
    int currentHealth;

    public HealthBar healthBar;

    public string WinScreen;
    void Start()
    {
        currentHealth = MaxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        //play damage animation
        Boss.SetTrigger("Damage");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("The Boss has died");
        Boss.SetBool("IsDead", true);

        GetComponent<Collider>().enabled = false;
        this.enabled = false;

        //Add points to the score
        Score.instance.AddPoint();
        SceneManager.LoadScene(WinScreen);
        Destroy(gameObject);


    }
}


