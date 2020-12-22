using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{


    public void PlayGame ()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame ()
    {
        Debug.Log("Right Now, The Game Would Have Closed, But We Are In The Unity Engine, So The Game Does Not Close");
        Application.Quit();
    }

}

