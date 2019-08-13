// Name: C# HW10
// Author: James Smelser
// Date: July 30, 2019

------------------------------------------------------------------------
# Homework 10, ISTA-220
## Chapter 10, C# Step by Step
### July 28, 2018
#### 1 Homework
##### 1.1 Readings
###### Read chapter 10, pages 221 - 242 in the C# Step by Step book.
###### 1.2 Discussion Questions
###### Answer the discussion questions in writing.
1. What does an array look like in memory?
- Contiguous block of memory accessed by using an index.
2. Where is memory allocated to hold an array, on the stack or on the heap?
- The heap.
3. Where is memory allocated to hold an array reference, on the stack or on the heap?
- The stack.
4. Can an array hold values of different types? This is a trick question, the answer is, It depends."
- No.
5. Describe the syntax of the condition or a foreach loop.
- The foreach statement declares an iteration variable (in this example, int pin) that automatically
acquires the value of each element in the array. (datatype, var name, keyword in, array name).
6. How do you make a deep copy of a array?
- First, you create a new array instance of the same type and the same length as the array you are copying. Second, you copy the data from the original array element by element to the new array (for loop).
7. What is the difference between a multi-dimensional array and an array of arrays?
- Instead of being a two-dimensional array, has only a single dimension, but the elements in that dimension are themselves arrays.
8. How do you "flatten" a multidimensional array? In other words, take something that looks like a
matrix
```
1 2 3
4 5 6
7 8 9
```
and turn it into an array [1; 2; 3; 4; 5; 6; 7; 8; 9]?
- Using a jagged array.
