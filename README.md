# Object-Oriented Programming (OOPs)

OOPs is a programming paradigm built on the concepts of classes and objects, emphasizing a shift from traditional logic-based systems.

## Relationship between Class and Object

A class acts as a blueprint, defining the structure, while an object is an instance, embodying the characteristics outlined by the class.

## Class Members

Class members, including fields and methods, encapsulate the essence of an object's behavior. Fields are the object's attributes, and methods define its actions.

## Constructors

Constructors are special methods initializing objects. Key considerations:
- Same name as the class.
- No abstract, final, or synchronized constructors.
- Single static constructor per class.
- No return type, even void.
- Static constructors cannot be parameterized.
- Multiple constructors allowed.
- Access modifiers control visibility.

### Types of Constructor

1. **Default Constructor**
2. **Parameterized Constructor**
3. **Copy Constructor**
4. **Private Constructor**
5. **Static Constructor**

## Why Access Modifiers?

Access modifiers dictate the visibility of class members, ensuring encapsulation and safeguarding sensitive data.

- **Public:** Accessible to all classes.
- **Private:** Accessible within the same class.
- **Protected:** Accessible within the same or inherited class.
- **Internal:** Accessible within its assembly.

## The Four Pillars of OOPs

1. **Encapsulation**
2. **Inheritance**
3. **Polymorphism**
4. **Abstraction**

### Encapsulation

Encapsulation conceals sensitive data from users, achieved by:
- Declaring fields as private.
- Providing public get and set methods (properties).

### Inheritance

Inheritance fosters the sharing of fields and methods between classes:
- **Derived Class (Child):** Inherits from another class.
- **Base Class (Parent):** Provides the blueprint.

### Polymorphism

Polymorphism allows treating objects of different types uniformly, promoting adaptability and dynamic behavior.

### Abstraction

Abstraction simplifies complex systems by highlighting essential details and hiding the unnecessary, enhancing clarity and maintainability.
