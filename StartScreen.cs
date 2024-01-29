//Dieses Skript wartet auf einen beliebigen Tastendruck im Startbildschirm, um die Anwendung zu starten.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void Update()
    {
        Cursor.visible = true;
        if (Input.anyKey)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
