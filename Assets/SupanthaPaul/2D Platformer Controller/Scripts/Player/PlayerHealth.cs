using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public bool isDead = false;

    public Sprite emptyHeart;
    public Sprite fullHeart;
    public Image[] hearts;

    

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Player took damage. Current health: " + currentHealth);

       
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < currentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if(i < maxHealth)
            {
                hearts[i].enabled = true;

            }
            else
            {
                hearts[i].enabled=false;
            }
        }
    }
    void Die()
    {
        Debug.Log("Player died!");
        isDead = true;

        
        SceneManager.LoadScene("LoserScreen");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "flag")
        {
            SceneManager.LoadScene("winnerScreen");
        }
    }

}
