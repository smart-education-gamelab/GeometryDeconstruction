using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public Color incorrectColor = new Color(0, 0, 0);
    public Color correctColor = new Color(0, 0.5f, 0);
    public Color incorrectTextColor = new Color(1, 1, 1);
    public Color correctTextColor = new Color(1, 1, 1);

    public int difficultylevel = 0;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
