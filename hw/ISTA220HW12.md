// Name: C# HW 12
// Author: James Smelser
// Date: August 7, 2019

------------------------------------------------------------
# Homework 12, ISTA-220
## Chapter 12, C# Step by Step
### July 28, 2018
#### 1 Homework
##### 1.1 Readings
###### Read chapter 12, pages 255 - 276 in the C# Step by Step book.
###### 1.2 Discussion Questions
###### Answer the discussion questions in writing.
1. How does inheritance promote the principle of don't repeat yourself (DRY)?
- Allows derived classes to inherit fields and methods from base classes.
2. What is the syntax of a derived class that inherits from a base class?
- class derived(): base().
3. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?
- System.Object.
4. What happens if you do not have a default constructor in a base class when creating a derived class?
- You have to create one.
5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?
- Yes derived classes can be assigned up to their base class.
6. Can you assign a variable of a derived class to another variable of a derived class of its base class?
Why or why not?
- No derived classes can not be assigned to each other because they are equal in the hierarchy.
7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?
- No base classes can not be assigned to their derived class.
8. Under what circumstances would you want to use the new keyword when defining a method in a derived class?
- When hiding another method of the same name.
9. What is a virtual method? Why would you want to define a virtual method?
- A method that can be overridden.
10. What does override do? Why does it do it?
- It declares another implementation of that method.
11. How do you define an extension type?
- This keyword.
12. Why do you define an extension type?
- If you need to quickly extend a type without affecting existing code.
