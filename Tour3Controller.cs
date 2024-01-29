//Dieses Skript steuert eine der Touren.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tour3Controller : MonoBehaviour
{
    public GameObject Visitor;
    public GameObject TourMenu;
    public GameObject Helptext;
    public VisitorMovement movementScript;
    public VisitorCamera moveCameraScript;
    public GameObject t3s01spawn;
    public GameObject t3s01o01;
    public GameObject t3s02spawn;
    public GameObject t3s02o01;
    public GameObject t3s03spawn;
    public GameObject t3s03o01;
    public GameObject t3s04spawn;
    public GameObject t3s04o01;
    public GameObject t3s05spawn;
    public GameObject t3s05o01;
    public GameObject t3s06spawn;
    public GameObject t3s06o01;
    public GameObject t3s07spawn;
    public GameObject t3s07o01;
    public GameObject t3s08spawn;
    public GameObject t3s08o01;
    public GameObject t3s09spawn;
    public GameObject t3s09o01;
    public GameObject t3s10spawn;
    public GameObject t3s10o01;

    private bool tourInProgress = false;

    // Start is called before the first frame update
    void Start()
    {
        Helptext.SetActive(false);
        t3s01o01.SetActive(false);
        t3s02o01.SetActive(false);
        t3s03o01.SetActive(false);
        t3s04o01.SetActive(false);
        t3s05o01.SetActive(false);
        t3s06o01.SetActive(false);
        t3s07o01.SetActive(false);
        t3s08o01.SetActive(false);
        t3s09o01.SetActive(false);
        t3s10o01.SetActive(false);
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
                if (t3s01o01.activeSelf)
                {
                    t3s01o01.SetActive(false);
                    t3s02o01.SetActive(true);
                    Visitor.gameObject.transform.position = t3s02spawn.gameObject.transform.position;
                }
                else if (t3s02o01.activeSelf)
                {
                    t3s02o01.SetActive(false);
                    t3s03o01.SetActive(true);
                    Visitor.gameObject.transform.position = t3s03spawn.gameObject.transform.position;   
                }
                else if (t3s03o01.activeSelf)
                {
                    t3s03o01.SetActive(false);
                    t3s04o01.SetActive(true);
                    Visitor.gameObject.transform.position = t3s04spawn.gameObject.transform.position;
                }
                else if (t3s04o01.activeSelf)
                {
                    t3s04o01.SetActive(false);
                    t3s05o01.SetActive(true);
                    Visitor.gameObject.transform.position = t3s05spawn.gameObject.transform.position;
                }
                else if (t3s05o01.activeSelf)
                {
                    t3s05o01.SetActive(false);
                    t3s06o01.SetActive(true);
                    Visitor.gameObject.transform.position = t3s06spawn.gameObject.transform.position;
                }
                else if (t3s06o01.activeSelf)
                {
                    t3s06o01.SetActive(false);
                    t3s07o01.SetActive(true);
                    Visitor.gameObject.transform.position = t3s07spawn.gameObject.transform.position;
                }
                else if (t3s07o01.activeSelf)
                {
                    t3s07o01.SetActive(false);
                    t3s08o01.SetActive(true);
                    Visitor.gameObject.transform.position = t3s08spawn.gameObject.transform.position;
                }
                else if (t3s08o01.activeSelf)
                {
                    t3s08o01.SetActive(false);
                    t3s09o01.SetActive(true);
                    Visitor.gameObject.transform.position = t3s09spawn.gameObject.transform.position;
                }
                else if (t3s09o01.activeSelf)
                {
                    t3s09o01.SetActive(false);
                    t3s10o01.SetActive(true);
                    Visitor.gameObject.transform.position = t3s10spawn.gameObject.transform.position;
                }
                else if (t3s10o01.activeSelf)
                {
                    t3s10o01.SetActive(false);
                    EndTour();
                }
            }
        }
    }
    public void StartTourThree()
    {
        TourMenu.SetActive(false);
        Helptext.SetActive(true);
        t3s01o01.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Visitor.gameObject.transform.position = t3s01spawn.gameObject.transform.position;
        movementScript.enabled = true;
        moveCameraScript.enabled = true;
        
        tourInProgress = true;
    }

    private void EndTour()
    {
        t3s01o01.SetActive(false);
        t3s02o01.SetActive(false);
        TourMenu.SetActive(false);
        Helptext.SetActive(false);
        tourInProgress = false;
        t3s03o01.SetActive(false);
        t3s04o01.SetActive(false);
        t3s05o01.SetActive(false);
        t3s06o01.SetActive(false);
        t3s07o01.SetActive(false);
        t3s08o01.SetActive(false);
        t3s09o01.SetActive(false);
        t3s10o01.SetActive(false);
    }
}
