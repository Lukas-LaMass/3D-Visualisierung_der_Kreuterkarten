//Dieses Skript steuert eine der Touren.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tour1Controller : MonoBehaviour
{
    public GameObject Visitor;
    public GameObject TourMenu;
    public GameObject Helptext;
    public VisitorMovement movementScript;
    public VisitorCamera moveCameraScript;
    public GameObject t1s01o01;
    public GameObject t1s01spawn;
    public GameObject t1s02o01;
    public GameObject t1s02spawn;
    public GameObject t1s03o01;
    public GameObject t1s03spawn;
    public GameObject t1s04o01;
    public GameObject t1s04spawn;
    public GameObject t1s05o01;
    public GameObject t1s05spawn;
    public GameObject t1s06o01;
    public GameObject t1s06spawn;
    public GameObject t1s07o01;
    public GameObject t1s07spawn;

    private bool tourInProgress = false;

    void Start()
    {
        t1s01o01.SetActive(false);
        t1s02o01.SetActive(false);
        Helptext.SetActive(false);
        t1s03o01.SetActive(false);
        t1s04o01.SetActive(false);
        t1s05o01.SetActive(false);
        t1s06o01.SetActive(false);
        t1s07o01.SetActive(false);
    }

    void Update()
    {
        if (tourInProgress)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                EndTour();
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (t1s01o01.activeSelf)
                {
                    t1s01o01.SetActive(false);
                    t1s02o01.SetActive(true);
                    Visitor.gameObject.transform.position = t1s02spawn.gameObject.transform.position;
                }
                else if (t1s02o01.activeSelf)
                {
                    t1s02o01.SetActive(false);
                    t1s03o01.SetActive(true);
                    Visitor.gameObject.transform.position = t1s03spawn.gameObject.transform.position;
                    
                }
                else if (t1s03o01.activeSelf)
                {
                    t1s03o01.SetActive(false);
                    t1s04o01.SetActive(true);
                    Visitor.gameObject.transform.position = t1s04spawn.gameObject.transform.position;
                    
                }
                else if (t1s04o01.activeSelf)
                {
                    t1s04o01.SetActive(false);
                    t1s05o01.SetActive(true);
                    Visitor.gameObject.transform.position = t1s05spawn.gameObject.transform.position;
                }
                else if (t1s05o01.activeSelf)
                {
                    t1s05o01.SetActive(false);
                    t1s06o01.SetActive(true);
                    Visitor.gameObject.transform.position = t1s06spawn.gameObject.transform.position;
                }
                else if (t1s06o01.activeSelf)
                {
                    t1s06o01.SetActive(false);
                    t1s07o01.SetActive(true);
                    Visitor.gameObject.transform.position = t1s07spawn.gameObject.transform.position;
                }
                else if (t1s07o01.activeSelf)
                {
                    EndTour();
                }
            }
        }
    }

    public void StartTourOne()
    {
        TourMenu.SetActive(false);
        Helptext.SetActive(true);
        t1s01o01.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Visitor.gameObject.transform.position = t1s01spawn.gameObject.transform.position;
        movementScript.enabled = true;
        moveCameraScript.enabled = true;
        
        tourInProgress = true;
    }

    private void EndTour()
    {
        t1s01o01.SetActive(false);
        t1s02o01.SetActive(false);
        TourMenu.SetActive(false);
        Helptext.SetActive(false);
        tourInProgress = false;
        t1s03o01.SetActive(false);
        t1s04o01.SetActive(false);
        t1s05o01.SetActive(false);
        t1s06o01.SetActive(false);
        t1s07o01.SetActive(false);
    }
}
