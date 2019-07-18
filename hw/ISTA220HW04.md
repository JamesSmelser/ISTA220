// Name: C# HW 4
// Author: James Smelser
// Date: July 10, 2019

--------------------------------------------------------------------
# C# Programming Homework 04
## Chapter 04, C# Step by Step
### Readings
#### Read chapter 4 in the C# Step by Step book.
##### Discussion Questions
###### Answer the discussion questions in writing for chapter 4.
1. What are all possible values of a Boolean expression?
- True and False.
2. List eight Boolean operators.
- Equal to, not equal to, less than, less than or equal to, greater than, greater than or equal to, logical and, logical or.
3. What is the general concept of short circuiting? This question has a short and simple answer and you
do not need to have a detailed response.
- It is not necessary to evaluate both operands when ascertaining the result of a conditional logical expression.
4. What are the difference in how short circuiting works for && and ||?
- If the left operand of the && operator evaluates to false, the result of the entire expression must be false, regardless of the value of the right operand. Similarly, if the value of the left operand of the || operator evaluates to true,
the result of the entire expression must be true, irrespective of the value of the right operand.
5. Look at the list of operators. What operator has the highest precedence? Which has the lowest?
- () precedence override, = assignment.
6. In an if or else construction using multiple lines of code, what effect does the use of curly braces have?
- A block is simply a sequence of statements grouped between an opening brace and a closing brace.
7. In a switch statement, what happens if you omit break?
- To forget the break statement, allowing execution to fall through to the next label and leading to bugs that are difficult to spot.
8. (Not in book) What is a recursive method? Using a language you know (such as English), write a
recursive method that adds up the integers in a list of integers. The input to the method is a list of
integers and the output is a scalar value representing a sum.
- When a method calls itself until it is satisfied.
```
{
start = 1
end = 10
int sum = 0
Console.WriteLine($"The sum is {sum}");
}
int recur(int start, int end, int sum)
{
   if (start > end)
     return sum
   else
     return recur(start + 1, end, sum + start)
}
```
