using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupControls : MonoBehaviour
{
    [SerializeField][Tooltip("Popuptutorial object")]
    private GameObject popupTutorial;

    [SerializeField][Tooltip("Popupinformation object")]
    private GameObject popupInformation;

    private bool IsTutorialOpen = false;
    private bool IsInfoOpen = false;

    private void ToggleTutorial()
    {
        IsTutorialOpen = !IsTutorialOpen;
    }

    private void ToggleInfo()
    {
        IsInfoOpen = !IsInfoOpen;
    }

    public void CloseTutorial()
    {
        if (!IsTutorialOpen) { return; }

        ToggleTutorial();
        //Set unactive.
        popupTutorial.SetActive(false);
    }

    public void OpenTutorial()
    {
        if (IsTutorialOpen) { return; }

        ToggleTutorial();
        //Set active.
        popupTutorial.SetActive(true);
    }

    public void OpenInformation()
    {
        if (IsInfoOpen) { return; }

        ToggleInfo();
        //Set active.
        popupInformation.SetActive(true);
    }

    public void CloseInformation()
    {
        if (!IsInfoOpen) { return; }

        ToggleInfo();
        //Set unactive.
        popupInformation.SetActive(false);
    }
}
