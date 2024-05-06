using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ConfirmButton : MonoBehaviour
{
    [SerializeField]
    private Button button;

    [SerializeField]
    private CheckForObject obj;

    private void Start()
    {
        button.onClick.AddListener(() => CheckTest());
    }

    public void UpdateCheck(CheckForObject check)
    {
        obj = check;
    }

    private void CheckTest()
    {       
        obj.CheckObjects();
    }

}
