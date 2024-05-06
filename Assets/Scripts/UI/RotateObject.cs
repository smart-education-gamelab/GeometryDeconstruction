using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateObject : MonoBehaviour
{

    public Button left;
    public Button right;
    public GameObject selectedObject;

    private void Start()
    {
        left.onClick.AddListener(RotateLeft);
        right.onClick.AddListener(RotateRight);
    }

    /// <summary>
    /// Rotate the object 90 degrees left
    /// </summary>
    public void RotateLeft()
    {
        selectedObject.transform.Rotate(0, -90, 0);
    }

    /// <summary>
    /// Rotate the object 90 degrees right
    /// </summary>
    public void RotateRight()
    {
        selectedObject.transform.Rotate(0, 90, 0);
    }
}
