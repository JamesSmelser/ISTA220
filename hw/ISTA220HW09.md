// Name: C# HW09
// Author: James Smelser
// Date: July 30, 2019

--------------------------------------------------
# Homework 09, ISTA-220
## Chapter 09, C# Step by Step
### 1 Homework
#### 1.1 Readings
##### Read chapter 9, pages 201 - 219 in the C# Step by Step book.
###### 1.2 Discussion Questions
###### Answer the discussion questions in writing.
1. Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols,
like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt?
```
enum Ranks
{
Private, Sergeant, Sergeant Major
}
```
2. Using the Ranks enum, assign a rank to yourself or a friend.
- Ranks James = Ranks.Sergeant;
3. Determine the numeric index of particular ranks, using the Ranks enum.
- Private = 0, Sergeant = 1, Sergeant Major = 2.
4. How do you select the type of an enum?
- enum Ranks : byte { Private, Sergeant, Sergeant Major }
5. Are structs stored on the stack or on the heap? What about enums?
- Structs are stored on the stack, enums are stored on the stack.
6. Declare a struct named DOD with four branches.
```
struct DOD
{
private string Army, Air Force, Marines, Navy;
}
```
7. Why can't you create a default constructor for a struct?
- Because the compiler always generates one.
8. What is CIL? What does the CLR do to the CIL?
- A pseudo-machine code (byte code) called the Common Intermediate Language (CIL). The CLR takes responsibility for converting the CIL instructions into real machine instructions that the processor on your computer can understand and execute.
