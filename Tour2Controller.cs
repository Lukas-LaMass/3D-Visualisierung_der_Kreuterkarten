//Dieses Skript steuert eine der Touren.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tour2Controller : MonoBehaviour
{
    public GameObject Visitor;
    public GameObject TourMenu;
    public GameObject Helptext;
    public VisitorMovement movementScript;
    public VisitorCamera moveCameraScript;
    public GameObject t2s01spawn;
    public GameObject t2s01o01;
    public GameObject t2s02o01;
    public GameObject t2s03spawn;
    public GameObject t2s03o01;
    public GameObject t2s04spawn;
    public GameObject t2s04o01;
    public GameObject t2s05o01;
    public GameObject t2s06spawn;
    public GameObject t2s06o01;
    public GameObject t2s07spawn;
    public GameObject t2s07o01;

    private bool tourInProgress = false;


    // Start is called before the first frame update
    void Start()
    {
        Helptext.SetActive(false);
        t2s01o01.SetActive(false);
        t2s02o01.SetActive(false);
        t2s03o01.SetActive(false);
        t2s04o01.SetActive(false);
        t2s05o01.SetActive(false);
        t2s06o01.SetActive(false);
        t2s07o01.SetActive(false);
    }

    // Update is called once per frame
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
                if (t2s01o01.activeSelf)
                {
                    t2s01o01.SetActive(false);
                    t2s02o01.SetActive(true);
                    Visitor.gameObject.transform.position = t2s01spawn.gameObject.transform.position;
                }
                else if (t2s02o01.activeSelf)
                {
                    t2s02o01.SetActive(false);
                    t2s03o01.SetActive(true);
                    Visitor.gameObject.transform.position = t2s03spawn.gameObject.transform.position;   
                }
                else if (t2s03o01.activeSelf)
                {
                    t2s03o01.SetActive(false);
                    t2s04o01.SetActive(true);
                    Visitor.gameObject.transform.position = t2s04spawn.gameObject.transform.position;
                }
                else if (t2s04o01.activeSelf)
                {
                    t2s04o01.SetActive(false);
                    t2s05o01.SetActive(true);
                    Visitor.gameObject.transform.position = t2s04spawn.gameObject.transform.position;
                }
                else if (t2s05o01.activeSelf)
                {
                    t2s05o01.SetActive(false);
                    t2s06o01.SetActive(true);
                    Visitor.gameObject.transform.position = t2s06spawn.gameObject.transform.position;
                }
                else if (t2s06o01.activeSelf)
                {
                    t2s06o01.SetActive(false);
                    t2s07o01.SetActive(true);
                    Visitor.gameObject.transform.position = t2s07spawn.gameObject.transform.position;
                }
                else if (t2s07o01.activeSelf)
                {
                    EndTour();
                }
            }
        }
    }
    public void StartTourTwo()
    {
        TourMenu.SetActive(false);
        Helptext.SetActive(true);
        t2s01o01.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Visitor.gameObject.transform.position = t2s01spawn.gameObject.transform.position;
        movementScript.enabled = true;
        moveCameraScript.enabled = true;
        
        tourInProgress = true;
    }
        private void EndTour()
    {
        t2s01o01.SetActive(false);
        t2s02o01.SetActive(false);
        TourMenu.SetActive(false);
        Helptext.SetActive(false);
        tourInProgress = false;
        t2s03o01.SetActive(false);
        t2s04o01.SetActive(false);
        t2s05o01.SetActive(false);
        t2s06o01.SetActive(false);
        t2s07o01.SetActive(false);
    }
}
