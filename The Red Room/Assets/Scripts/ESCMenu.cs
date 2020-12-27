using UnityEngine;
using System.Collections;

public class SomeScript : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("MainMenu");
        }
    }
}