using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialControls : MonoBehaviour
{
    [SerializeField][Tooltip("Popuptutorial object")]
    private GameObject popupTutorial;

    public void CloseTutorial()
    {
        popupTutorial.transform.position = new Vector2(0, 1000);
        popupTutorial.SetActive(false);
    }

    public void OpenTutorial()
    {
        popupTutorial.SetActive(true);
        popupTutorial.transform.position = new Vector2();
    }
}
