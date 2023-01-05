using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnRadius = 4, time = 1f;

    public GameObject[] enemies;

     void Start()
    {
        StartCoroutine(SpawnAnEnemy());
    }

    IEnumerator SpawnAnEnemy()
    {
        Vector2 spawnPos = GameObject.Find("Wizard").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(time);
        StartCoroutine(SpawnAnEnemy());
    }
}
