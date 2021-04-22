using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DiscordPresence;

public class SwitchScene1 : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene ("LevelPrototypes");
    }
}