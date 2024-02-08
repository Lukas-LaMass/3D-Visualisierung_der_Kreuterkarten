//Das Skritp kontrolliert die Anzeige eines Bestandsbilds. Es wird durch die Taste B aufgerufen und wieder geschlossen.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestandController : MonoBehaviour

{
    public GameObject Bestandbild;
    public bool BildanzeigeIsClosed;



    // Start is called before the first frame update
    void Start()
    {
        Bestandbild.SetActive(false);
        BildanzeigeIsClosed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            if(BildanzeigeIsClosed == true)
            {
                Bestandbild.SetActive(true);
                BildanzeigeIsClosed = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Bestandbild.SetActive(false);
                BildanzeigeIsClosed = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(BildanzeigeIsClosed == false)
            {
                Bestandbild.SetActive(false);
                BildanzeigeIsClosed = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
}
