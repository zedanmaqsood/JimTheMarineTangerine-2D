using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryMenuScript : MonoBehaviour
{
    [SerializeField] GameObject storyMenu;
    [SerializeField] GameObject[] characterStories;

    public void OpenJimStory()
    {
        AllSetFalseExcept(0);
    }

    public void OpenOfficeBobStory()
    {
        AllSetFalseExcept(1);
    }

    public void OpenBananasStory()
    {
        AllSetFalseExcept(2);
    }

    public void OpenTomatoesStory()
    {
        AllSetFalseExcept(3);
    }

    public void OpenCommissionerPatrickStory()
    {
        AllSetFalseExcept(4);
    }

    public void OpenBaguetteStory()
    {
        AllSetFalseExcept(5);
    }

    public void CloseStoryMenu()
    {
        storyMenu.SetActive(false);
    }

    void AllSetFalseExcept(int indexChar)
    {
        for (int i = 0; i < characterStories.Length; i++)
        {
            characterStories[i].SetActive(false);
        }
        characterStories[indexChar].SetActive(true);
    }
}
