// Name: C# HW 06
// Author: James Smelser
// Date: July 18, 2019

----------------------------------------
# Homework 06, ISTA-220
## Chapter 06, C# Step by Step
### 1 Homework
#### 1.1 Readings
##### Read chapter 6, pages 127 - 150 in the C# Step by Step book.
###### 1.2 Discussion Questions
###### Answer the discussion questions for chapter 6 in writing.
1. What is an exception?
- A response to an exceptional circumstance that arises while a program is running.
2. What happens in a try block if the program executes without errors?
- They all run, one after the other, to completion.
3. How does the catch mechanism work for unhandled exceptions?
- The calling method immediately exits, and execution returns to its caller, where the process is repeated.
4. What happens in a program if an exception block fails to handle a particular error?
- Returns to the caller where the process is repeated.
5. What is the parent class for all exceptions? How does this work?
- System.Exception, exceptions are organized into families called inheritance hierarchies.
6. How do you determine the type of an error?
- Filter by using the Boolean expression prefixed by the when keyword.
7. What is the purpose of integer checking?
- Allows for max size of a value to be increased.
8. What does thefinally block do?
- As long as the program enters the try block associated with a finally block, the finally block will always be run, even if an exception occurs.
