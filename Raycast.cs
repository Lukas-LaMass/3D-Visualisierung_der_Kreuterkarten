//Dies war ein experimentelles Skript, um sich mit der Funktion von Raycasts vertraut zu machen. In den Anwendungen wird es nicht verwendet.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{


    Ray ray;
    public LayerMask Selectable;

    // Start is called before the first frame update
    void Start()
    {
        ray = new Ray(transform.position, transform.forward);
        CheckForColliders();
    }

    // Update is called once per frame
    void CheckForColliders()
    {
        if (Physics.Raycast(ray, out RaycastHit hit, Selectable))
        {
            Debug.Log(hit+ "Hit");

        }
    }


}
