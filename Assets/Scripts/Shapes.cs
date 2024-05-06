using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constants;

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
                formula = LENGTH + LENGTH;
                break;
            case Shape.Rectangle:
                formula = "lw";
                formula = LENGTH + WIDTH;
                break;
            case Shape.Triangle:
                formula = "1/2wh";
                formula = HALF + WIDTH + HEIGHT;
                break;
            case Shape.Circle:
                formula = "πr^2";
                formula = PI + RADIUS + SQUARED;
                break;
            case Shape.Rhombus:
                formula = "1/2dd";
                formula = HALF + DIAGONAL + DIAGONAL;
                break;
            case Shape.Parallelogram:
                formula = "wh";
                formula = WIDTH + HEIGHT;
                break;
            case Shape.Cube:
                formula = "lll";
                formula = LENGTH + CUBED;
                break;
            case Shape.Cuboid:
                formula = "lwh";
                formula = LENGTH + WIDTH + HEIGHT;
                break;
            case Shape.Cylinder:
                formula = "πr^2h";
                formula = PI + RADIUS + SQUARED + HEIGHT;
                break;
            case Shape.Sphere:
                formula = "4/3πr^3";
                formula = FOURTHIRDS + PI + RADIUS + CUBED;
                break;
            case Shape.Cone:
                formula = "1/3πr^3";
                formula = ONETHIRDS + PI + RADIUS + CUBED;
                break;
            case Shape.TriangularPrism:
                formula = "1/2lwh";
                formula = HALF + LENGTH + WIDTH + HEIGHT;
                break;
            case Shape.RectangularPrism:
                formula = "lwh";
                formula = LENGTH + WIDTH + HEIGHT;
                break;
            case Shape.SquarePyramid:
                formula = "1/3l^2h";
                formula = ONETHIRDS + LENGTH + SQUARED + HEIGHT;
                break;
            case Shape.RectanglePyramid:
                formula = "1/3lwh";
                formula = ONETHIRDS + LENGTH + WIDTH + HEIGHT;
                break;
            case Shape.TrianglePyramid:
                formula = "1/6l^3/√2";
                formula = ONESIXTH + LENGTH + CUBED + ROOTTWO;
                break;
            case Shape.PentagonalPyramid:
                formula = "2(1+√2)/3l^2h";
                break;
            case Shape.HexagonalPyramid:
                formula = "√3/2l^2h";
                formula = ROOTTHREE + DIVISION + "2" + LENGTH + CUBED + HEIGHT;
                break;
            default:
                break;
        }

        return formula;
    }

}
