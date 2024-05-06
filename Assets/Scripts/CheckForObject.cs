using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CheckForObject : MonoBehaviour
{
    [SerializeField][Tooltip("List of prefabs to choose from and spawn")]
    private List<GameObject> prefabs;

    private GameObject currentObject;
    private ObjectInfo currentObjectInfo;

    [Tooltip("The dropdown script")]
    public Dropdown dropdown;

    private AudioSource audioSource;
    private AudioClip audioClip;

    private void Start()
    {
        //Find dropdown
        dropdown = Camera.main.GetComponent<Dropdown>();
        audioSource = Camera.main.GetComponent<AudioSource>();
        audioClip = audioSource.clip;

        RefreshObject();
    }

    /// <summary>
    /// Check wether objects are selected and correct
    /// </summary>
    public void CheckObjects()
    {
        currentObjectInfo.SetActivityChildren();
    }

    /// <summary>
    /// Destroy the curent object and replace it with a new one
    /// </summary>
    public void RefreshObject()
    {
        Destroy(currentObject);

        //Play music
        audioSource.PlayOneShot(audioClip);

        //Spawn new object
        GameObject prefab = prefabs[Random.Range(0, prefabs.Count)];
        currentObject = Instantiate(prefab, transform);
        currentObjectInfo = currentObject.GetComponent<ObjectInfo>();
    }

    /// <summary>
    /// Returns the index of the dropdown menu
    /// </summary>
    /// <returns>int dropdown value</returns>
    public int ReturnDropdownValue()
    {
        return dropdown.dropdownValue;
    }
}
