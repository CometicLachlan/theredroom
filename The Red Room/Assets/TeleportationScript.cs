using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationScript : MonoBehaviour
{
    public Transform Teleport;

    private void OnGUI()
    {
        if(GUI.Button(new Rect((float)-884.438, (float) -438.829, (float) -57.7, (float)95.61768), "BasePlate"))
        {
            transform.position = Teleport.position;
        }
    }
}
