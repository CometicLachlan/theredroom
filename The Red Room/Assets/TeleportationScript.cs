using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationScript : MonoBehaviour
{
    public Transform Teleport;

    private void OnGUI()
    {
        if(GUI.Button(new Rect(-884.438, -438.829, -57.7, 95.61768), "BasePlate"))
        {
            transform.position = Teleport.position;
        }
    }
}
