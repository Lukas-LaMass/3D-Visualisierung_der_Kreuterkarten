//Dieses Skript steuert eine der Touren.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tour1Controller : MonoBehaviour
{
    public GameObject Visitor;
    public GameObject TourMenu;
    public GameObject t1s01o01;
    public GameObject t1s01spawn;
    public GameObject t1s02o01;
    public GameObject t1s02spawn;

    private bool tourInProgress = false;

    // Start is called before the first frame update
    void Start()
    {
        // Deaktiviere alle Szenen zu Beginn
        t1s01o01.SetActive(false);
        t1s02o01.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (tourInProgress)
        {
            // Überprüfe, ob die Escape-Taste gedrückt wird, um die Tour abzubrechen
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                EndTour();
            }

            // Überprüfe, ob die F-Taste gedrückt wird, um zur nächsten Szene zu wechseln
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
                    // Füge hier die Logik für die nächste Szene hinzu, falls vorhanden
                }
            }
        }
    }

    public void StartTourOne()
    {
        // Deaktiviere das Tourmenü und starte die Tour
        TourMenu.SetActive(false);
        t1s01o01.SetActive(true);
        Visitor.gameObject.transform.position = t1s01spawn.gameObject.transform.position;

        // Markiere die Tour als gestartet
        tourInProgress = true;
    }

    private void EndTour()
    {
        // Setze alles zurück, um die Tour zu beenden
        t1s01o01.SetActive(false);
        t1s02o01.SetActive(false);
        TourMenu.SetActive(false);
        tourInProgress = false;
    }
}
