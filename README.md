# GCD Algorithm Calculator

A compact **C# .NET console application** that calculates the greatest common divisor of integers using both recursive and iterative implementations of the Euclidean algorithm.

<p>
  <img src="https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt=".NET 10" />
  <img src="https://img.shields.io/badge/Algorithm-Euclidean-238636?style=flat-square" alt="Euclidean Algorithm" />
  <img src="https://img.shields.io/badge/Status-Complete-238636?style=flat-square" alt="Project status: Complete" />
</p>

## Overview

GCD Algorithm Calculator is a focused practice project for comparing recursive and iterative control flow while solving the same mathematical problem with the same underlying algorithm.

The program accepts three integers, calculates the GCD of the first two values using both implementations of Euclid's algorithm, verifies that their answers match, reports the number of Euclidean reduction steps used by each implementation, and then calculates the GCD shared by all three inputs.

## Features

- Recursive Euclidean algorithm
- Iterative Euclidean algorithm
- Side-by-side result verification
- Euclidean step counting for both implementations
- GCD calculation across three integers
- Validation for console input
- Safe handling of negative integers
- Safe handling of the full 32-bit integer range, including `int.MinValue`
- Defined behavior for zero-valued inputs

## Euclidean Algorithm

For two non-negative integers `a` and `b`, the Euclidean algorithm repeatedly replaces the pair with:

```text
(a, b) -> (b, a mod b)
```

until the second value becomes `0`.

The remaining first value is the greatest common divisor.

For example:

```text
GCD(48, 18)
48 mod 18 = 12
18 mod 12 = 6
12 mod 6  = 0
GCD = 6
```

## Recursive Implementation

The recursive version expresses the next Euclidean step as another call to the same method:

```text
GCD(a, b) = GCD(b, a mod b)
```

with the base case:

```text
GCD(a, 0) = a
```

Each recursive call reduces the second argument until the base case is reached.

## Iterative Implementation

The iterative version performs the same remainder calculation inside a `while` loop. After each iteration, the divisor becomes the new first value and the remainder becomes the new second value.

Because both implementations use the same mathematical algorithm, they should produce the same answer and the same number of Euclidean reduction steps for a given pair of inputs.

## Three-Number GCD

The application extends the two-number calculation using the identity:

```text
GCD(a, b, c) = GCD(GCD(a, b), c)
```

This allows the same two-number Euclidean implementation to be reused without introducing a separate algorithm.

## Input Handling

The console accepts any valid C# `int` value.

Negative values are normalized before the GCD calculation. The program converts each `int` to `long` before applying `Math.Abs`, which safely handles `int.MinValue` without overflowing.

The application uses these zero-value rules:

```text
GCD(a, 0) = |a|
GCD(0, b) = |b|
```

Mathematically, `GCD(0, 0)` is undefined. For predictable program behavior, this application returns `0` when both inputs are zero.

## Example

```text
GCD Algorithm Calculator
------------------------
Enter the first integer: 48
Enter the second integer: 18
Enter the third integer: 30

Recursive GCD of 48 and 18: 6
Recursive Euclidean steps: 3

Iterative GCD of 48 and 18: 6
Iterative Euclidean steps: 3

Results match: True
GCD of 48, 18, and 30: 6
```

## Complexity

For positive inputs, Euclid's algorithm completes in logarithmic time relative to the smaller input value:

```text
O(log(min(a, b)))
```

The iterative version uses constant auxiliary space. The recursive version uses stack space proportional to the number of recursive calls.

## Technology

| Area | Technology |
| --- | --- |
| Language | C# |
| Runtime | .NET 10 |
| Interface | Console |
| Algorithm | Euclidean algorithm |
| Concepts | Recursion, iteration, modular arithmetic, validation |

## Project Structure

```text
GCDCalculator/
├── GreatestCommonDivisorRecursion/
│   ├── Program.cs
│   └── GreatestCommonDivisorRecursion.csproj
└── GreatestCommonDivisorRecursion.slnx
```

## Running the Project

### Requirements

- .NET 10 SDK, or
- Visual Studio with .NET development support

Clone the repository:

```bash
git clone https://github.com/IPFizzy/GCDCalculator.git
cd GCDCalculator
```

Run the application:

```bash
dotnet run --project GreatestCommonDivisorRecursion/GreatestCommonDivisorRecursion.csproj
```

Or open `GreatestCommonDivisorRecursion.slnx` in Visual Studio and run the project.

## Practice Project Context

This repository is preserved as a completed algorithm practice project. It demonstrates recursive and iterative implementations of the same algorithm, base cases, modular arithmetic, input normalization, result verification, step counting, and extension of a two-value algorithm to multiple inputs.

## Author

**Keon Bushman**  
Software Development Student & IT Professional  
[GitHub Profile](https://github.com/IPFizzy)
