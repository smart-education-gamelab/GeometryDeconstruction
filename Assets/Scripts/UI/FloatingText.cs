using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    [Tooltip("The main camera of the scene")]
    public Transform mainCamera;
    [Tooltip("The target which the text should be placed above")]
    public Transform geometryObject;
    [Tooltip("The canvas for the world text")]
    public Transform WorldSpaceCanvas;
    [Tooltip("Potential offset for the text to move it")]
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main.transform;
        Transform[] temp = FindObjectsByType<Transform>(FindObjectsSortMode.None);
        foreach (Transform i in temp)
        {
            if (i.CompareTag("WorldCanvas"))
            {
                WorldSpaceCanvas = i;
            }
            if (i.CompareTag("ObjectSpawner"))
            {
                geometryObject = i;
            }
        }

        transform.SetParent(WorldSpaceCanvas);
        transform.position = geometryObject.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate the text so it always faces the user
        transform.rotation = Quaternion.LookRotation(transform.position - mainCamera.position);
    }
}
