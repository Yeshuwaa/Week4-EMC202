using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] protected int _health = 5;
    [SerializeField] protected int _damage = 30;

    private bool hit = true;

    IEnumerator iFrame()
    {
        hit = false;
        yield return new WaitForSeconds(1f);
        hit = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            if (hit)
            {
                StartCoroutine(iFrame());
                _health--;
            }
        }
    }
}
