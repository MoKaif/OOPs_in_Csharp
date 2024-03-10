using System;

// Base class
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }

    // Method overloading
    public void Draw(string color)
    {
        Console.WriteLine($"Drawing a shape with color {color}");
    }
}

// Derived classes
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }

    // Method overloading in the derived class
    public void Draw(int radius)
    {
        Console.WriteLine($"Drawing a circle with radius {radius}");
    }
}

public class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }

    // Method overloading in the derived class
    public void Draw(double sideLength)
    {
        Console.WriteLine($"Drawing a square with side length {sideLength}");
    }
}

public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a triangle");
    }

    // Method overloading in the derived class
    public void Draw(double baseLength, double height)
    {
        Console.WriteLine($"Drawing a triangle with base {baseLength} and height {height}");
    }
}

class Program
{
    static void Main()
    {
        // Create an array of shapes
        Shape[] shapes = new Shape[]
        {
            new Circle(),
            new Square(),
            new Triangle()
        };

        // Iterate through the shapes and call the Draw methods
        foreach (var shape in shapes)
        {
            shape.Draw(); // Calls the overridden Draw method in each derived class
            shape.Draw("Red"); // Calls the overloaded Draw method in the base class with a color parameter
        }

        // Demonstrating method overloading in derived classes
        Circle circle = new Circle();
        circle.Draw(5); // Calls the overloaded Draw method in the Circle class with an integer parameter

        Square square = new Square();
        square.Draw(4.5); // Calls the overloaded Draw method in the Square class with a double parameter

        Triangle triangle = new Triangle();
        triangle.Draw(3.0, 6.0); // Calls the overloaded Draw method in the Triangle class with two double parameters
    }
}