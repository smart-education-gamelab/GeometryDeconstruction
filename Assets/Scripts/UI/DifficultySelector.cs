using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelector : MonoBehaviour
{
    public MenuControls menuControls;

    public void SelectDifficulty(int level)
    {
        MainManager.Instance.difficultylevel = level;
        menuControls.OpenGame();
    }
}