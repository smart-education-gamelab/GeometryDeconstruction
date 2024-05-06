using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FloatingHints : MonoBehaviour
{
    private TMP_Text tmp;
	
	void Start()
	{
		tmp = GetComponent<TMP_Text>();
	}

    public void UpdateText(string formula)
    {
        tmp.text = formula;
    }

    public void UpdateText(string formula, Color color)
    {
        tmp.text = formula;
        tmp.color = color;
    }
}
