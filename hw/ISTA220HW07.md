// Name: C# HW 07
// Author: James Smelser
// Date: July 22, 2019

---------------------------------------------
# Homework 07, ISTA-220
## Chapter 07, C# Step by Step
### July 28, 2018
#### 1 Homework
##### 1.1 Readings
###### Read chapter 7, pages 153 - 174 in the C# Step by Step book.
###### 1.2 Discussion Questions
###### Answer the discussion questions in writing.
1. What is a class? According to the book, what does a class arrange?"
- A systematic arranging of information and behavior into a meaningful entity. Fields and Methods.
2. What are the two purposes of encapsulation?
- To combine methods and data within a class; in other words, to support classification.
To control the accessibility of the methods and data; in other words, to control the use of
the class.
3. How do you instantiate an instance of a class? How do you access that instance?
- Create a variable of the class then initialize it using the new keyword. By calling the pointer
variable.
4. What is the default access of thefields and methods of a class? How do you change the default?
- Default is private, change it manually.
5. What is the syntax for writing a constructor?
- It is a specialized method with the same name as the class.
6. What is the difference between class fields and methods, and instance fields and methods? How do you
create class fields and methods?
- Class fields/methods are accessible anywhere in the class, instance fields/methods
are only accessible within that instance. Create within the class curly braces.
7. How do you bring a static class in scope? Why would you want to bring a static class in scope?
- Static using statements enable you to bring a class into scope and omit the class name when accessing static members.
It reduces the ammount of code.
8. Can you think of a good reason to create an anonymous class? What is it?
- When making numerous objects.
9. What is polymorphism as this term is used in computer science? This is not in the book.
- The ability of objects of different types to provide a unique interface for different implementations of methods.
10. What is message passing as this term is used in computer science? This is not in the book.
- It's called message passing to distinguish it from the imperative notion of "calling a function", and to reinforce the idea that the receiving object decides what to do.
11. What was thefirst object-oriented programming language?
- Simula.
12. Consider this quote by Alexander Stepanov:
Ifind OOP technically unsound. It attempts to decompose the world in terms of interfaces
that vary on a single type. To deal with the real problems you need multisorted algebras
| families of interfaces that span multiple types. I find OOP philosophically unsound. It
claims that everything is an object. Even if it is true it is not very interesting | saying that
everything is an object is saying nothing at all.
Who is Alexander Stepanov? What do you think about this quote?
- Computer programmer, best known as an advocate of generic programming and as
the primary designer and implementer of the C++ Standard Template Library. OOP is
simple in terms of design which makes it easier to use at a basic level but I agree
with Alexander that the world is more intricate than this simplest of approaches.
