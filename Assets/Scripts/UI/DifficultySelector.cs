using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelector : MonoBehaviour
{
    public MenuControls menuControls;

    [SerializeField]
    private PlaceARObject placeAR;

    [SerializeField]
    private GameObject difficultyButtons;

    public void SelectDifficulty(int level)
    {
        MainManager.Instance.difficultylevel = level;
        menuControls.OpenGame();
    }

    public void UpdateDifficulty(bool increaseDifficulty)
    {
        placeAR.obj.GetComponent<CheckForObject>().UpdateDifficulty(increaseDifficulty);
        CloseDifficulty();
    }

    public void OpenDifficulty()
    {
        difficultyButtons.SetActive(true);
    }

    public void CloseDifficulty()
    {
        difficultyButtons.SetActive(false);
    }
}