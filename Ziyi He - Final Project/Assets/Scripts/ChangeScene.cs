using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string URL = "https://github.com/TUD-ZH/Personal-project";

//start the game
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

//quit game
    public void QuitGame()
    {
        Debug.Log("Quit.");
        Application.Quit();
    }
    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void loadUrl()
    {
        Application.OpenURL(URL);
    }
}
