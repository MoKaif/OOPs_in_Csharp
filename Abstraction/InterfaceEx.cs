using System;

// Interface with method declarations
public interface IShape
{
    void Draw();
}

// Another interface for additional functionality
public interface IResizable
{
    void Resize(int percentage);
}

// Class implementing both interfaces
public class Circle : IShape, IResizable
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }

    public void Resize(int percentage)
    {
        Console.WriteLine($"Resizing the circle by {percentage}%.");
    }
}

class Program
{
    static void Main()
    {
        // Creating an object of the class implementing the interfaces
        Circle circle = new Circle();

        // Calling methods from the interfaces
        circle.Draw();         // Calls the Draw method from the IShape interface
        circle.Resize(20);     // Calls the Resize method from the IResizable interface
    }
}
