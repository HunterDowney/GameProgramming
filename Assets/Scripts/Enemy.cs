using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int maxHealth = 100;
    int currentHealth;
    public Animator animator;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {

        currentHealth = maxHealth;






    }

     
    public void takeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }

    }

    void Die()
    {

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
