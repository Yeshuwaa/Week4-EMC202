using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

[CreateAssetMenu]
public class ClassDataBase : ScriptableObject
{
    
    public Class[] character;

    public int CharacterCount
    {
        get
        {
            return character.Length;
        }
    }

    public Class GetCharacter(int index)
    {
        return character[index];
    }
}
