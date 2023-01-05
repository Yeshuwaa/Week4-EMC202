using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator playerAnimation;
    public float attackDelay;
    public Transform weaponTransform;
    public float weaponRange;
    public int weaponDamage;
    public LayerMask enemyLayer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Slash());
        }
    }
    IEnumerator Slash()
    {
        playerAnimation.Play("Player (Attack)");
        Collider2D enemy = Physics2D.OverlapCircle(weaponTransform.position, weaponRange, enemyLayer);

        yield return new WaitForSeconds(attackDelay);
    }
}
