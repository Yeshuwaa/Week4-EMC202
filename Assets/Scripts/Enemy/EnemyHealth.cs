using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float enemyHealth, maxHealth = 50f;

    public AudioSource audioSource;
    public AudioClip sfx;

    public void Start()
    {
        enemyHealth = maxHealth;
    }
    public void TakeDamage(float amount)
    {

        enemyHealth -= amount;
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
