using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constants
{
    public enum Shape
    {
        None,
        Square,
        Rectangle,
        Triangle,
        Circle,
        Sphere,
        Rhombus,
        Parallelogram,
        Pentagon,
        Hexagon,
        LateralSurfaceCylinder,
        LateralSurfaceCone,
        Cube,
        Cuboid,
        Cylinder,
        Cone,
        TriangularPrism,
        RectangularPrism,
        SquarePyramid,
        RectanglePyramid,
        TrianglePyramid,
        PentagonalPyramid,
        HexagonalPyramid
    }

    public enum Shape2D
    {
        None,
        Square,
        Rectangle,
        Triangle,
        Circle,
        Sphere,
        Rhombus,
        Parallelogram,
        Pentagon,
        Hexagon,
        LateralSurfaceCylinder,
        LateralSurfaceCone
    }

    public enum Shape3D
    {
        None,
        Cube,
        Cuboid,
        Cylinder,
        Sphere,
        Cone,
        TriangularPrism,
        RectangularPrism,
        SquarePyramid,
        RectanglePyramid,
        TrianglePyramid,
        PentagonalPyramid,
        HexagonalPyramid
    }

    public static Color INCORRECTRGB = new Color(0, 0, 0);
    public static Color CORRECTRGB = new Color(0, 0.5f, 0);
    public static Color TEXTRGB = new Color(1, 1, 1);

    //Variables for formula creation, THESE ARE CURRENTLY NOT USED
    public static string LENGTH = "l";
    public static string WIDTH = "w";
    public static string HEIGHT = "h";
    public static string RADIUS = "r";
    public static string DIAGONAL = "d";
    public static string PI = "π";
    public static string ONETHIRDS = "1/3";
    public static string HALF = "1/2";
    public static string TWOTHIRDS = "2/3";
    public static string FOURTHIRDS = "4/3";
    public static string ONESIXTH = "1/6";
    public static string SQUARED = "^2";
    public static string CUBED = "^3";
    public static string MULTIPLY = " x ";
    public static string DIVISION = " / ";
    public static string ROOTTWO = "√2";
    public static string ROOTTHREE = "√3";
}
