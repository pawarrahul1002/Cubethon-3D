using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyController : MonoBehaviour
{
    public string menuSceneName;
    public string gameSceneName;
    public void MenuButtonClick()
    {
        SceneManager.LoadScene(menuSceneName);
    }

    public void PlayButtonClick()
    {
        SceneManager.LoadScene(gameSceneName);
    }
    public void QuitButtonClick()
    {
        Application.Quit();
    }
}
