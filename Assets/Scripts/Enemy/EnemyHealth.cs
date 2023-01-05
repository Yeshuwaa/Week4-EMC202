using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth = 100;
    
    public void TakeDamage(int amount)
    {
        enemyHealth -= amount;
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

}
