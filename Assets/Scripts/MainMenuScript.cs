using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] GameObject storyMenu;

    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void StoryOption()
    {
        storyMenu.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
