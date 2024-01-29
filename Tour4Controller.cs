//Dieses Skript steuert eine der Touren.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tour4Controller : MonoBehaviour
{
    public GameObject Visitor;
    public GameObject TourMenu;
    public GameObject Helptext;
    public VisitorMovement movementScript;
    public VisitorCamera moveCameraScript;
    public GameObject t4s01spawn;
    public GameObject t4s01o01;
    public GameObject t4s02spawn;
    public GameObject t4s02o01;
    public GameObject t4s03spawn;
    public GameObject t4s03o01;
    public GameObject t4s04spawn;
    public GameObject t4s04o01;
    public GameObject t4s05spawn;
    public GameObject t4s05o01;
    public GameObject t4s06spawn;
    public GameObject t4s06o01;
    public GameObject t4s07spawn;
    public GameObject t4s07o01;
    public GameObject t4s08spawn;
    public GameObject t4s08o01;
    public GameObject t4s09spawn;
    public GameObject t4s09o01;
    public GameObject t4s10spawn;
    public GameObject t4s10o01;

    private bool tourInProgress = false;

    // Start is called before the first frame update
    void Start()
    {
        Helptext.SetActive(false);
        t4s01o01.SetActive(false);
        t4s02o01.SetActive(false);
        t4s03o01.SetActive(false);
        t4s04o01.SetActive(false);
        t4s05o01.SetActive(false);
        t4s06o01.SetActive(false);
        t4s07o01.SetActive(false);
        t4s08o01.SetActive(false);
        t4s09o01.SetActive(false);
        t4s10o01.SetActive(false);
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
                if (t4s01o01.activeSelf)
                {
                    t4s01o01.SetActive(false);
                    t4s02o01.SetActive(true);
                    Visitor.gameObject.transform.position = t4s02spawn.gameObject.transform.position;
                }
                else if (t4s02o01.activeSelf)
                {
                    t4s02o01.SetActive(false);
                    t4s03o01.SetActive(true);
                    Visitor.gameObject.transform.position = t4s03spawn.gameObject.transform.position;   
                }
                else if(t4s03o01.activeSelf)
                {
                    t4s03o01.SetActive(false);
                    t4s04o01.SetActive(true);
                    Visitor.gameObject.transform.position = t4s04spawn.gameObject.transform.position;
                }
                else if(t4s04o01.activeSelf)
                {
                    t4s04o01.SetActive(false);
                    t4s05o01.SetActive(true);
                    Visitor.gameObject.transform.position = t4s05spawn.gameObject.transform.position;
                }
                else if(t4s05o01.activeSelf)
                {
                    t4s05o01.SetActive(false);
                    t4s06o01.SetActive(true);
                    Visitor.gameObject.transform.position = t4s06spawn.gameObject.transform.position;
                }
                else if(t4s06o01.activeSelf)
                {
                    t4s06o01.SetActive(false);
                    t4s07o01.SetActive(true);
                    Visitor.gameObject.transform.position = t4s07spawn.gameObject.transform.position;
                }
                else if(t4s07o01.activeSelf)
                {
                    t4s07o01.SetActive(false);
                    t4s08o01.SetActive(true);
                    Visitor.gameObject.transform.position = t4s08spawn.gameObject.transform.position;
                }
                else if(t4s08o01.activeSelf)
                {
                    t4s08o01.SetActive(false);
                    t4s09o01.SetActive(true);
                    Visitor.gameObject.transform.position = t4s09spawn.gameObject.transform.position;
                }
                else if(t4s09o01.activeSelf)
                {
                    t4s09o01.SetActive(false);
                    t4s10o01.SetActive(true);
                    Visitor.gameObject.transform.position = t4s10spawn.gameObject.transform.position;
                }
                else if(t4s10o01.activeSelf)
                {
                    t4s10o01.SetActive(false);
                    EndTour();
                }
            }
        }    
    }
    public void StartTourFour()
    {
        TourMenu.SetActive(false);
        Helptext.SetActive(true);
        t4s01o01.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Visitor.gameObject.transform.position = t4s01spawn.gameObject.transform.position;
        movementScript.enabled = true;
        moveCameraScript.enabled = true;
        
        tourInProgress = true;
    }

    private void EndTour()
    {
        t4s01o01.SetActive(false);
        t4s02o01.SetActive(false);
        TourMenu.SetActive(false);
        Helptext.SetActive(false);
        tourInProgress = false;
        t4s03o01.SetActive(false);
        t4s04o01.SetActive(false);
        t4s05o01.SetActive(false);
        t4s06o01.SetActive(false);
        t4s07o01.SetActive(false);
        t4s08o01.SetActive(false);
        t4s09o01.SetActive(false);
        t4s10o01.SetActive(false);
    }
}
