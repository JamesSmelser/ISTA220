// Name: C# HW 13
// Author: James Smelser
// Date: August 10, 2019

----------------------------------------------------------------------------
# Homework 13, ISTA-220
## Chapter 13, C# Step by Step
### 1 Homework
#### 1.1 Readings
##### Read chapter 13, pages 277 - 293 in the C# Step by Step book.
###### 1.2 Discussion Questions
###### Answer the discussion questions in writing.
1. What is an interface as the term is used on object-oriented programming?
- An interface contains only the signatures of methods, properties, events or indexers. A class or struct that implements the interface must implement the members of the interface that are specified in the interface definition.
2. How do you define an interface?
- Use the interface keyword.
3. Can an interface have variables, fields, or properties?
- No, only methods with no statements.
4. How do you define a method in an interface?
- return type, method name, parameters, semicolon.
5. Can you instantiate an object through an interface? Why or why not?
- Yes.
6. Using the new keyword, can you declare a reference to an interface?
- No, but you can assign an interface to a variable of an appropriate class.
7. Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how
can it do so?
- No, all interface methods must be provided in the class, it must be named in the class.
8. What does it mean to explicitly implement an interface?
- Specify which interface a method belongs to when you implement it.
9. What are the restrictions on interfaces?
- You’re not allowed to define any fields in an interface, not even static fields. You’re not allowed to define any constructors in an interface. You’re not allowed to define a destructor in an interface. You cannot specify an access modifier for any method. You cannot nest any types inside an interface. An interface is not allowed to inherit from a structure or a class, although an interface can inherit from another interface.
10. What is the difference between an abstract class and an interface?
- Abstract class has implementation.
11. What is an abstract method?
- An abstract method is similar in principle to a virtual method except that it does not contain a method body.
12. What is an sealed class?
- Use the sealed keyword to prevent a class from being used as a base class.
13. What is an sealed method?
- Use the sealed keyword to declare that an individual method in an unsealed class is sealed,
this means that a derived class cannot override this method.
