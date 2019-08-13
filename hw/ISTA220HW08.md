// Name: C# HW 08
// Author: James Smelser
// Date: July 23, 2019

----------------------------------------------------------------
# Homework 08, ISTA-220
## Chapter 08, C# Step by Step
### July 28, 2018
#### 1 Homework
##### 1.1 Readings
###### Read chapter 8, pages 77 - 199 in the C# Step by Step book.
###### 1.2 Discussion Questions
###### Answer the discussion questions in writing.
1. What is the difference between deep copy and shallow copy?
- A shallow copy only copies references, deep copy copies the same data from another class instance.
2. What is the value of a reference after you declare and initialize it?
- The address of an object in memory, creates a new instance of the class.
3. How do you declare a value type?
- Value type, variable
4. How do you declare a reference type?
- Class, variable
5. Does C# allow you to assign NULL to a value type?
- Yes, but only when using a null conditional operator.
6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?
- No, because the nullable value may contain null and the other can not.
7. What is the difference between the stack and the heap?
- stack holds memory for executing the program, heap contains objects you create.
8. What does it mean when we say that all classes are specialized types?
- Specialized types under the System.Object class.
9. What does ref do?
- Compiler generates code that passes a reference to the actual argument rather than a copy of the argument.
10. What does out do?
- Returns a value without using the return keyword.
11. Describe boxing and unboxing in your own words.
- Boxing takes value from the stack and force it to be stored on the heap with a reference, unboxing takes a value type from the heap and stores it on the stack by casting it to a compatible value type.
12. What does cast do?
- By using a cast, you can specify that the data referenced by an object has a specific type and that it is safe to reference the object by using that type.
