using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] protected int _health;

    private bool hit = true;

    public AudioSource audioSource;
    public AudioClip sfx;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            if (hit)
            {
                StartCoroutine(Iframe());
                _health--;
                if (_health <= 0)
                {
                    StartCoroutine(DeathSfx());
                }
            }
        }
    }
    IEnumerator DeathSfx()
    {
        audioSource.clip = sfx;
        audioSource.Play();
        yield return new WaitForSeconds(.3f);
        Destroy(gameObject);
        SceneManager.LoadScene("MainMenu");
    }

    IEnumerator Iframe()
    {
        hit = false;
        yield return new WaitForSeconds(.3f);
        hit = true;
    }

}