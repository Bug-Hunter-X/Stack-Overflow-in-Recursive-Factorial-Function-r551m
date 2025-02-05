# F# Recursive Factorial Bug

This repository demonstrates a common error in recursive functions in F#:  a Stack Overflow Exception caused by improper handling of base cases.

The `factorialBug.fs` file contains a recursive factorial function that doesn't handle negative input, resulting in infinite recursion. The `factorialSolution.fs` provides a corrected version.

## How to Reproduce

1.  Clone the repository.
2.  Open `factorialBug.fs` in an F# editor (like Visual Studio).
3.  Run the code. You'll observe a `StackOverflowException`.

## Solution

The solution is to add a check for negative input and return an appropriate value (like an error value or throw an exception). See the `factorialSolution.fs` file for the corrected code.