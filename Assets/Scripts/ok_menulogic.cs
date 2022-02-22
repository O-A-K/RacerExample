using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ok_menulogic : MonoBehaviour
{

    public int in_scenedestination;

    public void SwitchScene()
    {
        SceneManager.LoadScene(in_scenedestination);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
