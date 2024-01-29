//Dieses Skript erzeugt die dynamische Linie der Tourdisplays.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TwoPointLine : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    private LineRenderer line;

    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    void Update()
    {
        line.positionCount = 2;
        line.SetPosition(0, pointA.position);
        line.SetPosition(1, pointB.position);
    }
}
