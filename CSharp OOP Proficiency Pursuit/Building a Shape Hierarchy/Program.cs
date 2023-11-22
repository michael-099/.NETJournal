using System;
namespace ShapeHierarchy;
class Shape
{
    public string Name;
    double CalculateArea()
    {
        return 0;

    }


    public class Circle
    {
        double Radius;
        // double pie = Math.PI;

        public static double CalculateArea(double Radius)
        {
            double pie = Math.PI;
            double area = pie * (Math.Pow(Radius, 2));
            return area;

        }


    }

    public class Rectangle
    {
        double Width;
        double Height;
        public static double CalculateArea(double Width, double Height)
        {
            double area = Width * Height;
            return area;
        }


    }

    public class Triangle
    {
        double Base;
        double Height;
        public static double CalculateArea(double Base, double Height)
        {
            double area = (Base * Height) / 2;
            return area;
        }



    }

    void PrintShapeArea(Shape shape)
    {


    }




}
class main
{
    static void Main(string[] args)
    {
        Shape shape = new Shape();
        shape.Name = "Circle";
        Console.WriteLine(Shape.Circle.CalculateArea(3));

    }
}