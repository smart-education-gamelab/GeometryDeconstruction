using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public GameObject buttonObjects;
    public GameObject tutorialObjects;
    public GameObject settingsObjects;
    public GameObject informationObjects;
    public GameObject difficultyObjects;

    #region buttoncontrols
    public void OpenGame()
    {
        SceneManager.LoadScene("ARDeconstruction");
    }
    public void OpenSelectDifficulty()
    {
        buttonObjects.SetActive(false);
        difficultyObjects.SetActive(true);
    }

    public void CloseSelectDifficulty()
    {
        buttonObjects.SetActive(true);
        difficultyObjects.SetActive(false);
    }

    public void OpenSettings()
    {
        buttonObjects.SetActive(false);
        settingsObjects.SetActive(true);
    }

    public void CloseSettings()
    {
        buttonObjects.SetActive(true);
        settingsObjects.SetActive(false);
    }

    public void OpenInformation()
    {
        buttonObjects.SetActive(false);
        informationObjects.SetActive(true);
    }

    public void CloseInformation()
    {
        buttonObjects.SetActive(true);
        informationObjects.SetActive(false);
    }

    public void OpenTutorial()
    {
        buttonObjects.SetActive(false);
        tutorialObjects.SetActive(true);
    }

    public void CloseTutorial()
    {
        buttonObjects.SetActive(true);
        tutorialObjects.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    #endregion

    #region colors
    public void SetIncorrectColor(Color newColor)
    {
        MainManager.Instance.incorrectColor = newColor;
    }

    public void SetCorrectColor(Color newColor)
    {
        MainManager.Instance.correctColor = newColor;
    }

    public void SetIncorrectTextColor(Color newColor)
    {
        MainManager.Instance.incorrectTextColor = newColor;
    }

    public void SetCorrectTextColor(Color newColor)
    {
        MainManager.Instance.correctTextColor = newColor;
    }
    #endregion
}
