using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using static Constants;

public static class Formulas
{
    public static bool CheckFormula(Shape shape, string formula)
    {
        formula = formula.ToLower();
        bool result = false;

        switch (shape)
        {
            case Shape.None:
                break;
            case Shape.Square:
                if (formula.Equals(CheckFormula(Shape2D.Square)) || 
                    formula.Equals(CheckFormula(Shape2D.Rectangle)) || 
                    formula.Equals(CheckFormula(Shape2D.Rhombus)) || 
                    formula.Equals(CheckFormula(Shape2D.Parallelogram))) { result = true; }
                break;
            case Shape.Rectangle:
                if (formula.Equals(CheckFormula(Shape2D.Rectangle)) || 
                    formula.Equals(CheckFormula(Shape2D.Parallelogram))) { result = true; }
                break;
            case Shape.Triangle:
                if (formula.Equals(CheckFormula(Shape2D.Triangle))) { result = true; }
                break;
            case Shape.Circle:
                if (formula.Equals(CheckFormula(Shape2D.Circle))) { result = true; }
                break;
            case Shape.Rhombus:
                if (formula.Equals(CheckFormula(Shape2D.Rhombus))) { result = true; }
                break;
            case Shape.Parallelogram:
                if (formula.Equals(CheckFormula(Shape2D.Parallelogram)) || 
                    formula.Equals(CheckFormula(Shape2D.Rhombus))) { result = true; }
                break;
            case Shape.Pentagon:
                if (formula.Equals(CheckFormula(Shape2D.Pentagon))) { result = true; }
                break;
            case Shape.Hexagon:
                if (formula.Equals(CheckFormula(Shape2D.Hexagon))) { result = true; }
                break;
            case Shape.LateralSurfaceCylinder:
                if (formula.Equals(CheckFormula(Shape2D.LateralSurfaceCylinder))) { result = true; }
                break;
            case Shape.LateralSurfaceCone:
                if (formula.Equals(CheckFormula(Shape2D.LateralSurfaceCone))) { result = true; }
                break;
            case Shape.Cube:
                break;
            case Shape.Cuboid:
                break;
            case Shape.Cylinder:
                break;
            case Shape.Sphere:
                if (formula.Equals(CheckFormula(Shape2D.Sphere))) { result = true; }
                break;
            case Shape.Cone:
                break;
            case Shape.TriangularPrism:
                break;
            case Shape.RectangularPrism:
                break;
            case Shape.SquarePyramid:
                break;
            case Shape.RectanglePyramid:
                break;
            case Shape.TrianglePyramid:
                break;
            case Shape.PentagonalPyramid:
                break;
            case Shape.HexagonalPyramid:
                break;
            default:
                break;
        }

        return result;

    }

    public static string CheckFormula(Shape2D shape)
    {
        string formula = "";

        switch (shape)
        {
            case Shape2D.Square:
                formula = "ll";
                break;
            case Shape2D.Rectangle:
                formula = "lw";
                break;
            case Shape2D.Triangle:
                formula = "1/2wh";
                break;
            case Shape2D.Circle:
                formula = "πr^2";
                break;
            case Shape2D.Sphere:
                formula = "4πr^2";
                break;
            case Shape2D.Rhombus:
                formula = "1/2dd";
                break;
            case Shape2D.Parallelogram:
                formula = "wh";
                break;
            case Shape2D.Pentagon:
                formula = "1/2wh5";
                break;
            case Shape2D.Hexagon:
                formula = "1/2wh6";
                break;
            case Shape2D.LateralSurfaceCylinder:
                formula = "2πrh";
                break;
            case Shape2D.LateralSurfaceCone:
                formula = "πrs";
                break;
            default:
                break;
        }
        return formula;
    }

    public static string CheckFormula(Shape3D shape)
    {
        string formula = "";

        switch (shape)
        {
            case Shape3D.Cube:
                formula = "lll";
                break;
            case Shape3D.Cuboid:
                formula = "lwh";
                break;
            case Shape3D.Cylinder:
                formula = "πr^2h";
                break;
            case Shape3D.Sphere:
                formula = "4/3πr^3";
                break;
            case Shape3D.Cone:
                formula = "1/3πr^3";
                break;
            case Shape3D.TriangularPrism:
                formula = "1/2lwh";
                break;
            case Shape3D.RectangularPrism:
                formula = "lwh";
                break;
            case Shape3D.SquarePyramid:
                formula = "1/3l^2h";
                break;
            case Shape3D.RectanglePyramid:
                formula = "1/3lwh";
                break;
            case Shape3D.TrianglePyramid:
                formula = "1/6l^3/√2";
                break;
            case Shape3D.PentagonalPyramid:
                formula = "2(1+√2)/3l^2h";
                break;
            case Shape3D.HexagonalPyramid:
                formula = "√3/2l^2h";
                break;
            default:
                break;
        }
        return formula;
    }
}
