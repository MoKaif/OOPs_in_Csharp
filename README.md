What is OOPS?
--> OOPs is a programming paradigm that is built on concepts of class and objects rather than usual logic based system.

Relationship between class and object
--> A class is like a template or blueprint of an object. An object is the instance of the class

Class Members
--> Fields and methods inside classes are often referred to as "Class Members": variables inside a class are called fields, and that you can access them by creating an object of the class, and by using the dot syntax (.) You can also leave the fields blank, and modify them when creating the object: Methods normally belong to a class, and they define how an object of a class behaves.
Just like with fields, you can access methods with the dot syntax. However, note that the method must be public. And remember that we use the name of the method followed by two parentheses () and a semicolon ; to call (execute) the method:

Constructors
--> A constructor is a special method that is used to initialize objects. The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields
Important points to Remember About Constructors

    Constructor of a class must have the same name as the class name in which it resides.
    A constructor can not be abstract, final, and Synchronized.
    Within a class, you can create only one static constructor.
    A constructor doesn’t have any return type, not even void.
    A static constructor cannot be a parameterized constructor.
    A class can have any number of constructors.
    Access modifiers can be used in constructor declaration to control its access i.e which other class can call the constructor.

Types of Constructor
Default Constructor
Parameterized Constructor
Copy Constructor
Private Constructor
Static Constructor

Why Access Modifiers?

public The code is accessible for all classes
private The code is only accessible within the same class
protected The code is accessible within the same class, or in a class that is inherited from that class.
internal The code is only accessible within its own assembly, but not from another assembly.
To control the visibility of class members (the security level of each individual class and class member).

To achieve "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users. This is done by declaring fields as private.

- The Four Pillars of OOPs:
  --Encapsulation
  -- inheritence
  -- polymorphism
  -- Abstraction

Encapsulation
The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:

    declare fields/variables as private
    provide public get and set methods, through properties, to access and update the value of a private field

What is Properties in C#
A property is like a combination of a variable and a method, and it has two methods: a get and a set method:

```
class Person
{
  private string name; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
}
```

Why Encapsulation?
    Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
    Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)
    Flexible: the programmer can change one part of the code without affecting other parts
    Increased security of data

Inheritance (Derived and Base Class)
In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:
    Derived Class (child) - the class that inherits from another class
    Base Class (parent) - the class being inherited from

