using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CheckForObject : MonoBehaviour
{
    [SerializeField][Tooltip("List of prefabs to choose from and spawn")]
    private List<GameObject> prefabs;

    [SerializeField][Tooltip("List of level 1 prefabs")]
    private List<GameObject> level1;

    [SerializeField][Tooltip("List of level 2 prefabs")]
    private List<GameObject> level2;

    [SerializeField][Tooltip("List of level 3 prefabs")]
    private List<GameObject> level3;

    [SerializeField][Tooltip("List of level 4 prefabs")]
    private List<GameObject> level4;

    private List<GameObject> prefabList;

    private int difficultylevel = 0;

    private GameObject currentObject;
    private ObjectInfo currentObjectInfo;

    [Tooltip("The dropdown script")]
    public Dropdown dropdown;

	//TODO Make an audio manager when using more sounds
    private AudioSource audioSource;
    private AudioClip audioClip;

    private void Start()
    {
        //Find dropdown
        dropdown = Camera.main.GetComponent<Dropdown>();
        
		//Get the audiosource and clip
		audioSource = Camera.main.GetComponent<AudioSource>();
        audioClip = audioSource.clip;

        UpdatePrefabList();
        SpawnObject();
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
        prefabList.Remove(currentObject);
        if(prefabList.Count == 0)
        {
            difficultylevel++;
            UpdatePrefabList();
        }
        Destroy(currentObject);

        //Play music
        audioSource.PlayOneShot(audioClip);
        
        SpawnObject();
    }
	
	private void SpawnObject()
	{
		//Spawn new object
        //GameObject prefab = prefabs[Random.Range(0, prefabs.Count)];
        GameObject prefab = GetObject();
        currentObject = Instantiate(prefab, transform);
        currentObjectInfo = currentObject.GetComponent<ObjectInfo>();
	}

    private GameObject GetObject()
    {
        GameObject tempprefab = prefabList[Random.Range(0, prefabList.Count)];

        return tempprefab;
    }

    private void UpdatePrefabList()
    {
        prefabList.Clear();

        switch (difficultylevel)
        {
            //level 1 only
            case 0:
                prefabList.AddRange(level1);
                break;
            //level 1 & 2
            case 1:
                prefabList.AddRange(level1);
                prefabList.AddRange(level2);
                break;
            //level 2 & 3
            case 2:
                prefabList.AddRange(level2);
                prefabList.AddRange(level3);
                break;
            //level 3 & 4
            case 3:
                prefabList.AddRange(level3);
                prefabList.AddRange(level4);
                break;
            case 4:
                //Loop the current hardest difficulty
                difficultylevel = 3;
                break;
            default:
                Debug.LogError("Not a valid difficulty level");
                break;
        }
    }
		
    /// <summary>
    /// Returns the index of the dropdown menu
    /// </summary>
    /// <returns>int dropdown value</returns>
    public int ReturnDropdownValue()
    {
        return dropdown.dropdownValue;
    }

    public void SetDifficulty(int level)
    {
        difficultylevel = level;
    }
}
