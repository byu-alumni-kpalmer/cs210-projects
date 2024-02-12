using System;


abstract class Shape
{
    
    public abstract double CalculateArea();
}


class Circle : Shape
{
    private double radius; 

    
    public Circle(double radius)
    {
        this.radius = radius;
    }

    
    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    
    public override double CalculateArea()
    {
        return Math.PI * radius * radius; 
    }
}


class Square : Shape
{
    private double sideLength; 

   
    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    
    public double SideLength
    {
        get { return sideLength; }
        set { sideLength = value; }
    }

    
    public override double CalculateArea()
    {
        return sideLength * sideLength; 
    }
}


class Triangle : Shape
{
    private double baseLength; 
    private double height; 

    
    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    
    public double BaseLength
    {
        get { return baseLength; }
        set { baseLength = value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    
    public override double CalculateArea()
    {
        return 0.5 * baseLength * height; 
    }
}


class Rectangle : Shape
{
    private double length; 
    private double width; 

    
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    
    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    
    public override double CalculateArea()
    {
        return length * width; 
    }
}


class Rhombus : Shape
{
    private double diagonal1; 
    private double diagonal2; 

    
    public Rhombus(double diagonal1, double diagonal2)
    {
        this.diagonal1 = diagonal1;
        this.diagonal2 = diagonal2;
    }

    
    public double Diagonal1
    {
        get { return diagonal1; }
        set { diagonal1 = value; }
    }

    public double Diagonal2
    {
        get { return diagonal2; }
        set { diagonal2 = value; }
    }

    
    public override double CalculateArea()
    {
        return 0.5 * diagonal1 * diagonal2; 
    }
}


class Pentagon : Shape
{
    private double sideLength; 

    
    public Pentagon(double sideLength)
    {
        this.sideLength = sideLength;
    }

    
    public double SideLength
    {
        get { return sideLength; }
        set { sideLength = value; }
    }

    
    public override double CalculateArea()
    {
        return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * sideLength * sideLength; 
    }
}


class Program
{
    static void Main()
    {
        
        Circle circle = new Circle(5);
        Square square = new Square(10);
        Triangle triangle = new Triangle(6, 8);
        Rectangle rectangle = new Rectangle(4, 5);
        Rhombus rhombus = new Rhombus(6, 8);
        Pentagon pentagon = new Pentagon(7);

        
        Console.WriteLine("Area of Circle: " + circle.CalculateArea());
        Console.WriteLine("Area of Square: " + square.CalculateArea());
        Console.WriteLine("Area of Triangle: " + triangle.CalculateArea());
        Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());
        Console.WriteLine("Area of Rhombus: " + rhombus.CalculateArea());
        Console.WriteLine("Area of Pentagon: " + pentagon.CalculateArea());
    }
}
