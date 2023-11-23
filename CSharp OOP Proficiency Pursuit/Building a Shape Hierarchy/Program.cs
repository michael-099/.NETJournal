using System;
namespace ShapeHierarchy;
public class Shape
{
    private string Name;
    public void setName(string name)
    {
        Name = name;
    }
    public string getName()
    {
        return Name;
    }
    public virtual double CalculateArea()
    {
        return 0;

    }
}

public class Circle : Shape
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

    public override double CalculateArea()
    {
        double pie = Math.PI;
        double area = pie * (Math.Pow(Radius, 2));
        return area;

    }


}

public class Rectangle : Shape
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
        Height = height;
    }
    public double getHeight()
    {
        return Height;
    }
    public override double CalculateArea()
    {
        double area = Width * Height;
        return area;
    }


}

public class Triangle : Shape
{
    private double Base;
    public void setBase(double baseedge)
    {
        Base = baseedge;
    }
    public double getBase()
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
    public override double CalculateArea()
    {
        double area = (Base * Height) / 2;
        return area;
    }
}


class main
{
    static void PrintShapeArea(Shape shape)
    {
        Console.WriteLine($"{shape.getName()}   {shape.CalculateArea()}");
    }
    static void Main(string[] args)
    {
        
            Circle circle = new Circle();
            circle.setName("cir");
            circle.setRadius(3.0);
            PrintShapeArea(circle);

            Rectangle rectangle = new Rectangle();
            rectangle.setName("rect");
            rectangle.setWidth(4.0);
            rectangle.setHeight(5.0);
            PrintShapeArea(rectangle);

            Triangle triangle = new Triangle();
            triangle.setName("tri");
            triangle.setBase(3.0);
            triangle.setHeight(4.0);
            PrintShapeArea(triangle);
       


    }
}