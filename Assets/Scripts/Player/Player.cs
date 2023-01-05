using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] protected int _health;
    [SerializeField] protected int _damage;

    private bool hit = true;

    public ClassDataBase classDB;

    public SpriteRenderer artworkSprite;

    private int selectedOption = 0;

    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }

        else
        {
            Load();
        }

        UpdateCharacter(selectedOption);
    }

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
    private void UpdateCharacter(int selectedOption)
    {
        Class character = classDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.classSprite;
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("SelectedOption");
    }
}
