using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constants;

//NOTE: Only used for the filling and getting values related to the dropdown menu
public class Shapes
{
    private Shape shape;
    private string originalFormula;
    public string currentformula;
    private int dropdownIndex;

    public Shapes(Shape s, string formula, int index)
    {
        shape = s;
        originalFormula = formula;
        dropdownIndex = index;
    }

    /// <summary>
    /// Get the Shape
    /// </summary>
    /// <returns>Shape enum</returns>
    public Shape GetShape()
    {
        return shape;
    }

    /// <summary>
    /// Get the formula
    /// </summary>
    /// <returns></returns>
    public string GetFormula()
    {
        return originalFormula;
    }

    /// <summary>
    /// Get the index
    /// </summary>
    /// <returns></returns>
    public int GetIndex()
    {
        return dropdownIndex;
    }

    //NOTE:this one isn't being used, the one in Formulas.cs is the one being used. 
    /// <summary>
    /// Get the default formula for the given shape
    /// </summary>
    /// <param name="shape">Shape you want to know the formula for</param>
    /// <returns>string formula</returns>
    public string GetDefaultFormula(Shape shape)
    {
        string formula = "";

        switch (shape)
        {
            case Shape.None:
                break;
            case Shape.Square:
                formula = "ll";
                break;
            case Shape.Rectangle:
                formula = "lw";
                break;
            case Shape.Triangle:
                formula = "1/2wh";
                break;
            case Shape.Circle:
                formula = "πr^2";
                break;
            case Shape.Rhombus:
                formula = "1/2dd";
                break;
            case Shape.Parallelogram:
                formula = "wh";
                break;
            case Shape.Cube:
                formula = "lll";
                break;
            case Shape.Cuboid:
                formula = "lwh";
                break;
            case Shape.Cylinder:
                formula = "πr^2h";
                break;
            case Shape.Sphere:
                formula = "4/3πr^3";
                break;
            case Shape.Cone:
                formula = "1/3πr^3";
                break;
            case Shape.TriangularPrism:
                formula = "1/2lwh";
                break;
            case Shape.RectangularPrism:
                formula = "lwh";
                break;
            case Shape.SquarePyramid:
                formula = "1/3l^2h";
                break;
            case Shape.RectanglePyramid:
                formula = "1/3lwh";
                break;
            case Shape.TrianglePyramid:
                formula = "1/6l^3/√2";
                break;
            case Shape.PentagonalPyramid:
                formula = "2(1+√2)/3l^2h";
                break;
            case Shape.HexagonalPyramid:
                formula = "√3/2l^2h";
                break;
            default:
                break;
        }

        return formula;
    }

}
