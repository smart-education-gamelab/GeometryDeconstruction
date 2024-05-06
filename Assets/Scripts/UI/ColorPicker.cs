using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    public TMP_Text Tmp;
    public Image img;

    public void SetColor(Color newColor)
    {
        if (img != null)
        {
            img.color = newColor;
        }
        else if(Tmp != null)
        {
           Tmp.color = newColor;
        }
        else
        {
            Debug.LogError("Component needs a Image or TMP_Text");
        }
    }
}
