using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public Text scoreTextInGame;
    public Text scoreTextDisplay;
    private void Awake()
    {
        scoreTextDisplay.text = "Score: " + scoreTextInGame.text;
    }

    public void PlayAgain()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadSceneAsync(1);
    }

    public void GoToMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadSceneAsync(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
