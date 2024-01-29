//Dieses Skript steuert das Spawnmenü.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour

{
    public GameObject SpawnMenu;
    public bool SpawnMenueIsClosed;



    // Start is called before the first frame update
    void Start()
    {
        SpawnMenu.SetActive(false);
        SpawnMenueIsClosed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(SpawnMenueIsClosed == true)
            {
                SpawnMenu.SetActive(true);
                SpawnMenueIsClosed = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                SpawnMenu.SetActive(false);
                SpawnMenueIsClosed = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(SpawnMenueIsClosed == false)
            {
                SpawnMenu.SetActive(false);
                SpawnMenueIsClosed = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
}
