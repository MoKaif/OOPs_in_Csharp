using System;

// Abstract class with abstract and regular methods
public abstract class Animal
{
    // Abstract method without a body
    public abstract void MakeSound();

    // Regular method in the abstract class
    public void Sleep()
    {
        Console.WriteLine("The animal is sleeping.");
    }
}

// Derived class inheriting from the abstract class
public class Dog : Animal
{
    // Implementation of the abstract method in the derived class
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Program
{
    static void Main()
    {
        // Creating an object of the derived class
        Dog dog = new Dog();

        // Calling methods from the abstract class
        dog.MakeSound(); // Calls the overridden MakeSound method in the Dog class
        dog.Sleep();     // Calls the Sleep method from the abstract class
    }
}
