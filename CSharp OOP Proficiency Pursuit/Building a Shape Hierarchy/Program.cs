using System;
namespace ShapeHierarchy;
class Shape
{
    private  string Name;
    public void setName(string name){
        Name=name ;
    }
    public string getName(){
        return Name;
    }
    double CalculateArea()
    {
        return 0;

    }


    public class Circle
    {
        private double Radius;
        public void setRadius(double radius)
        {
            Radius = radius;
        }
        public double getRadius()
        {
            return Radius;
        }
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
        private double Width;
        public void setWidth(double width)
        {
            Width = width;
        }
        public double getWidth()
        {
            return Width;
        }
        private double Height;
        public void setHeight(double height)
        {
            Height = Height;
        }
        public double getHeight()
        {
            return Height;
        }
        public static double CalculateArea(double Width, double Height)
        {
            double area = Width * Height;
            return area;
        }


    }

    public class Triangle
    {
        private double Base;
        public void setBase(double baseedge)
        {
            Base = baseedge;
        }
        public double getBaset()
        {
            return Base;
        }
        private double Height;
        public void setHeight(double height)
        {
            Height = height;
        }
        public double getHeight()
        {
            return Height;
        }
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
        shape.setName("Circle");
        Console.WriteLine(shape.getName());
        Console.WriteLine(Shape.Circle.CalculateArea(3));

    }
}