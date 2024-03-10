# Abstraction in C#

Abstraction is a fundamental concept in object-oriented programming that involves hiding certain details and exposing only essential information to the user. In C#, abstraction is commonly achieved through abstract classes and interfaces.

## Abstract Classes

An abstract class is a restricted class that cannot be instantiated on its own; it needs to be inherited by another class. It may contain abstract methods (methods without a body) that must be implemented by derived classes. Abstract classes can also have regular methods with implementations.

### Key Points about Abstract Classes:

- **Keyword:** `abstract` keyword is used for declaring abstract classes.
- **Multiple Inheritance:** C# supports single inheritance, so a class can inherit from only one abstract class.
- **Method Declaration:** Abstract classes can declare both abstract and regular methods.
- **Implementation:** Abstract methods declared in an abstract class must be implemented by derived classes.

## Interfaces

An interface is a contract that defines a set of methods (and properties) that a class must implement. Unlike abstract classes, interfaces cannot contain method implementations or fields. A class can implement multiple interfaces, providing flexibility in design.

### Key Points about Interfaces:

- **Keyword:** `interface` keyword is used for declaring interfaces.
- **Multiple Inheritance:** C# supports multiple interface inheritance, allowing a class to implement multiple interfaces.
- **Method Declaration:** Interfaces only declare method signatures without providing implementations.
- **Implementation:** Classes implementing an interface must provide concrete implementations for all interface members.

## Differences between Abstract Classes and Interfaces

| Feature                 | Abstract Classes                  | Interfaces                     |
|-------------------------|-----------------------------------|--------------------------------|
| **Keyword**             | `abstract`                        | `interface`                    |
| **Multiple Inheritance**| Not supported                     | Supported                      |
| **Method Declaration**  | Can declare abstract and regular methods | Only declares method signatures |
| **Implementation**      | Abstract methods must be implemented by derived classes | Concrete implementations must be provided by the class implementing the interface |

## When to Use Abstract Classes or Interfaces:

- **Use Abstract Classes When:**
  - You want to provide a common base class with some default implementation.
  - You want to use access modifiers (public, private, protected) for members.
  - You need to share code among related classes.

- **Use Interfaces When:**
  - You want to define a contract for unrelated classes.
  - You want to achieve multiple inheritance.
  - You need to provide a common set of methods across different class hierarchies.

Understanding when to use abstract classes or interfaces depends on the specific requirements of your design and the relationships between your classes.
