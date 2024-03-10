using System;

public class ConstructorEx
{
    // Default Constructor
    public ConstructorEx()
    {
        Console.WriteLine("Default Constructor invoked");
    }

    // Parameterized Constructor
    string text;
    public ConstructorEx(string msg)
    {
        text = msg;
        Console.WriteLine("Parameterized Constructor invoked with message " + msg);
    }

    // Copy Constructor
    public ConstructorEx(ConstructorEx obj)
    {

        Console.WriteLine("Copy Constructor containing message: " + obj.text);
    }

    // Private Constructor
    private ConstructorEx(int privateParameter)
    {
        Console.WriteLine($"Private Constructor: {privateParameter}");
    }
    // Static Constructor
    static ConstructorEx()
    {
        Console.WriteLine("Static Constructor");
        // Initialize static data if needed
    }

}

using System;

class Program
{
    static void Main()
    {
        // Default Constructor
        ConstructorEx defaultConstructorObj = new ConstructorEx();

        // Parameterized Constructor
        ConstructorEx parameterizedConstructorObj = new ConstructorEx(" Hello!");

        // Copy Constructor
        ConstructorEx copyConstructorObj = new ConstructorEx(parameterizedConstructorObj);

        // Private Constructor (Cannot be instantiated directly)
        // ConstructorExample privateConstructorObj = new ConstructorExample(42); // This line will result in a compilation error

        // Static Constructor
        // Called automatically before any static members are accessed
    }
}
