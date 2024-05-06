using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColorPickButton : MonoBehaviour
{
    public UnityEvent<Color> ColorPickerEvent;

    [SerializeField]
    Texture2D colorChart;

    [SerializeField]
    RectTransform cursor;

    [SerializeField]
    Image cursorColor;

    [SerializeField]
    List<GameObject> otherCharts;

    public void PickColor(BaseEventData data)
    {
        PointerEventData pointer = data as PointerEventData;

        cursor.position = pointer.position;

        Color pickedColor = colorChart.GetPixel((int)(cursor.localPosition.x * (colorChart.width / transform.GetChild(0).GetComponent<RectTransform>().rect.width)),
            (int)(cursor.localPosition.y * (colorChart.height / transform.GetChild(0).GetComponent<RectTransform>().rect.height)));
        cursorColor.color = pickedColor;
        ColorPickerEvent.Invoke(pickedColor);

    }

    public void DisableOtherCharts()
    {
        foreach (GameObject item in otherCharts)
        {
            if (item.activeInHierarchy)
            {
                item.SetActive(false);
            }
        }
    }
}
