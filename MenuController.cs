//Dieses Skript regelt das Verhalten der Menüführung.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    //public GameObject Visitor;
    public GameObject MainMenu;
    public GameObject About;
    public GameObject Help;
    public GameObject Tours;
    public GameObject Options;
    public VisitorMovement movementScript;
    public VisitorCamera moveCameraScript;
    public bool MainMenuIsClosed;
    public bool AboutIsClosed;
    public bool HelpIsClosed;
    public bool ToursIsClosed;
    public bool OptionsIsClosed;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(false);
        MainMenuIsClosed = true;
        About.SetActive(false);
        AboutIsClosed = true;
        Help.SetActive(false);
        HelpIsClosed = true;
        Tours.SetActive(false);
        ToursIsClosed = true;
        Options.SetActive(false);
        OptionsIsClosed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(MainMenuIsClosed == true)
            {
                //Visitor.SetActive(false);
                MainMenu.SetActive(true);
                MainMenuIsClosed = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                movementScript.enabled = false;
                moveCameraScript.enabled = false;
            }
            else
            {
                //Visitor.SetActive(true);
                MainMenu.SetActive(false);
                MainMenuIsClosed = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                movementScript.enabled = true;
                moveCameraScript.enabled = true;
            }
            if(AboutIsClosed == false)
            {
                
                About.SetActive(false);
                AboutIsClosed = true;
                MainMenu.SetActive(false);
                MainMenuIsClosed = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                movementScript.enabled = true;
                moveCameraScript.enabled = true;
            }
            if(HelpIsClosed == false)
            {
                
                Help.SetActive(false);
                HelpIsClosed = true;
                MainMenu.SetActive(false);
                MainMenuIsClosed = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                movementScript.enabled = true;
                moveCameraScript.enabled = true;
            }
            if(ToursIsClosed == false)
            {
                Tours.SetActive(false);
                ToursIsClosed = true;
                MainMenu.SetActive(false);
                MainMenuIsClosed = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                movementScript.enabled = true;
                moveCameraScript.enabled = true;
            }
            if(OptionsIsClosed == false)
            {
                Options.SetActive(false);
                OptionsIsClosed = true;
                MainMenu.SetActive(false);
                MainMenuIsClosed = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                movementScript.enabled = true;
                moveCameraScript.enabled = true;
            }
        }
    }

    public void OpenAbout()
    {
        About.SetActive(true);
        AboutIsClosed = false;
        MainMenu.SetActive(false);
        MainMenuIsClosed = true;
    }

    public void CloseAbout()
    {
        About.SetActive(false);
        AboutIsClosed = true;
        MainMenu.SetActive(true);
        MainMenuIsClosed = false;
    }

    public void OpenHelp()
    {
        Help.SetActive(true);
        HelpIsClosed = false;
        MainMenu.SetActive(false);
        MainMenuIsClosed = true;
    }

    public void CloseHelp()
    {
        Help.SetActive(false);
        HelpIsClosed = true;
        MainMenu.SetActive(true);
        MainMenuIsClosed = false;
    }

    public void OpenTours()
    {
        Tours.SetActive(true);
        ToursIsClosed = false;
        MainMenu.SetActive(false);
        MainMenuIsClosed = true;
    }

    public void CloseTours()
    {
        Tours.SetActive(false);
        ToursIsClosed = true;
        MainMenu.SetActive(true);
        MainMenuIsClosed = false;
    }

    public void OpenOptions()
    {
        Options.SetActive(true);
        OptionsIsClosed = false;
        MainMenu.SetActive(false);
        MainMenuIsClosed = true;
    }

    public void CloseOptions()
    {
        Options.SetActive(false);
        OptionsIsClosed = true;
        MainMenu.SetActive(true);
        MainMenuIsClosed = false;
    }

    public void CloseMainMenu()
    {
        MainMenu.SetActive(false);
        MainMenuIsClosed = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        movementScript.enabled = true;
        moveCameraScript.enabled = true;
    }

    public void EndApp()
    {
        Application.Quit();
    }
}
