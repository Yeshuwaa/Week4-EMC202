using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public GameObject HitConfirm;

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(HitConfirm, transform.position, Quaternion.identity);
        Destroy(effect, .5f);
        Destroy(gameObject);
    }
}
