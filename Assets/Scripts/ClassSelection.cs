using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSelection : MonoBehaviour
{
    public GameObject player;
    public GameObject cam;
    public GameObject cam2;
    public GameObject classPanel;

    public void ActivateObject()
    {
        if (player.activeSelf != true)
        {
            player.SetActive(true); cam.SetActive(true); cam2.SetActive(true); classPanel.SetActive(false);
        }
        else
        {
            player.SetActive (false); cam.SetActive(false); cam2.SetActive(false); classPanel.SetActive(false);
        }
    }
}
