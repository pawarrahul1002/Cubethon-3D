using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public string currentScene;
    public float restartDelay;
    public GameObject completeLevelUI;
    public GameObject playAgainLevelUI;
    public Text finalScoreText;
    public PlayerMovement player;
    public EndTrigger end;



    public void CompleteLevel()
    {
        Debug.Log("Level completed");
        completeLevelUI.SetActive(true);

    }

    public void EndGame()
    {
        if (gameHasEnded == false && end.completed == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        playAgainLevelUI.SetActive(true);
        finalScoreText.text = "Score : " + player.score.ToString("0");
    }

}
