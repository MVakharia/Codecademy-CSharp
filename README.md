# Codecademy-CSharp
 
Code written while studying C# with Codecademy.

## Topics for further study:

- The 'char' data type.

- Statically typed and dynamically typed languages, and strongly and weakly typed languages, and the differences and overlap.

### Try/Catch explained

- Create two curly-braced blocks: one named 'try', and the other named 'catch'.
- If you have code that you think could crash your program or otherwise generate an error, place it in the 'try' block.
- If the program is about to crash or generate an error while stepping through the 'try' block, execution of the 'try' block stops immediately, before the program can crash or throw an error.
- Execution is then passed to the beginning of the 'catch' block.
- In order for the 'catch' block to work, there needs to be a parameter in the 'catch' block braces: this parameter will normally be of a type in the 'Exception' class, for example (Exception e).

It's bad practice to only have a single 'catch' block with a parameter of (Exception e): ideally you want to have multiple catch blocks with more specific params ((FormatException e), for example) so that the user knows exactly what went wrong.

- Using bash (dotnet run) to run a C# program.

- string.Substring, string.Split, and other 'string' functions. 

- %=

'continue'—this, along with 'break', are collectively known as 'jump' statements.

The difference between 'do while' loops and 'while' loops

Generics

Array methods and List methods - Remove(), Clear(), Contains(), AddRange(), InsertRange(), RemoveRange()

Named Arguments

Getting subclasses and superclasses mixed up

The 'as' operator

Upcasting and downcasting

The 'is' operator

Static constructors

Interfaces

Value types and reference types

Comparing two value types with ==, vs comparing two reference types with ==

Structs

Referencing objects through other objects in their hierarchy, or through the interfaces they implement.

Math.Round

Math.Round with an argument of type 'double' will round a midpoint double to the nearest even integer. For example, 6.5 will be rounded to 6, and 11.5 will be rounded to 12.
Invariant Culture

GetHashCode
