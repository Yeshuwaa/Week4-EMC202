using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CastingFireball : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sfx;

    public Transform firePoint;
    public GameObject fireballPrefab;

    public float fireballForce = 20f;

    public float attackDelay;
    public Transform weaponTransform;
    public int magicDamage;
    public float weaponRange;
    public LayerMask enemyLayer;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            MagicCast();
            StartCoroutine(FireballCast());
            audioSource.clip = sfx;
            audioSource.Play();
        }
    }

    void MagicCast()
    {
        GameObject bullet = Instantiate(fireballPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(firePoint.up * fireballForce, ForceMode2D.Impulse);
    }

    IEnumerator FireballCast()
    {
        Collider2D enemy = Physics2D.OverlapCircle(weaponTransform.position, weaponRange, enemyLayer);
        yield return new WaitForSeconds(attackDelay);
        enemy.GetComponent<EnemyHealth>().TakeDamage(magicDamage);
    }
}
