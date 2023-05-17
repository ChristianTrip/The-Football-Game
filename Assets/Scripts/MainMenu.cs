using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void GoToScene(string sceneName)
    {
        if (sceneName.Equals("Try again"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        SceneManager.LoadScene(sceneName);
        Debug.Log("Switched scene to " + sceneName);
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Application has quit");
    }
}
