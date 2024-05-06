using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Constants;
using System;
using System.Linq;

/// <summary>
/// Dropdown information placed on the Main Camera for easy acces.
/// </summary>
public class Dropdown : MonoBehaviour
{
    [Tooltip("The dropdown UI element")]
    public TMP_Dropdown dropdwon;
    [Tooltip("All the different formulas")]
    public List<string> formulas;

    private List<int> shapeNum = new List<int>();
    private List<Shapes> shapes = new List<Shapes>();

    public string currentFormula = "";
    public int dropdownValue = 0;

    public Dictionary<int, string> dictionairy;

    // Start is called before the first frame update
    private void Start()
    {
        dictionairy = Enum.GetValues(typeof(Shape))
               .Cast<Shape>()
               .ToDictionary(t => (int)t, t => t.ToString());

        for (int i = 0; i < formulas.Count; i++)
        {
            shapes.Add(new Shapes((Shape)i+1, formulas[i].ToUpper(), i+1));
            formulas[i] = shapes[i].GetFormula().ToUpper();
            shapeNum.Add(shapes[i].GetIndex());
        }
        PopulateDropdown();
        currentFormula = formulas[dropdwon.value];
    }

    /// <summary>
    /// Populates the dropdown with the formulas
    /// </summary>
    public void PopulateDropdown()
    {
        dropdwon.ClearOptions();
        dropdwon.AddOptions(formulas);
    }

    /// <summary>
    /// Handles the input
    /// </summary>
    /// <param name="val">The current selected index of the dropdown</param>
    public void HandleInputData(int val)
    {
        currentFormula = formulas[val];
        dropdownValue = val;
    }

    /// <summary>
    /// Returns the shape data from the currently selected value
    /// </summary>
    /// <returns>Shapes</returns>
    public Shapes GetShape()
    {
        return shapes[dropdownValue];
    }
}
