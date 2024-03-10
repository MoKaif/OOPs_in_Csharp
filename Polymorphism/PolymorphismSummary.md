# Polymorphism in C#

Polymorphism, meaning "many forms," is a key concept in object-oriented programming that enables objects of different types to be treated as objects of a common base type. In C#, polymorphism is primarily achieved through method overriding and method overloading.

## Method Overriding

In method overriding, a derived class provides a specific implementation for a method already defined in its base class. This allows objects of different derived classes to be treated uniformly through a common interface. The overridden method is determined at runtime based on the actual type of the object.

## Method Overloading

Method overloading occurs when a class has multiple methods with the same name but different parameter lists. This enables a method to perform different tasks based on the number or types of parameters passed to it. Overloaded methods are determined at compile-time based on the method signature.

## Key Points:

- **Base Class Reference, Derived Class Object:**
  - Polymorphism allows using a reference to the base class to refer to objects of derived classes.

- **Dynamic Method Invocation:**
  - The specific method to be executed is determined at runtime, facilitating dynamic behavior.

- **Code Flexibility and Extensibility:**
  - Polymorphism enhances code flexibility by allowing the integration of new derived classes without modifying existing code.

- **Overriding vs. Overloading:**
  - Overriding occurs when a method in a derived class provides a specific implementation for a method in the base class. Overloading involves having multiple methods with the same name but different parameters in the same class.

Understanding polymorphism in C# is fundamental for designing flexible and scalable object-oriented systems.
