# Akvelon FizzBuzz

A simple C# implementation of the Akvelon FizzBuzz coding task.

## Overview

The library processes an input string and:

- Replaces every 3rd word with **Fizz**
- Replaces every 5th word with **Buzz**
- Replaces words whose position is divisible by both 3 and 5 with **FizzBuzz**
- Preserves the original formatting (spaces, punctuation, and line breaks)
- Returns the transformed string together with the total number of replacements

## Project Structure

- **FizzBuzzDetector** – Main class that processes the input.
- **FizzBuzzResult** – Represents the output string and replacement count.
- **Unit Tests** – Covers the main scenarios of the task.

## Input Constraints

The input must satisfy the following conditions:

- The input string cannot be `null`.
- The input length must be between **7** and **100** characters.

## Usage

```csharp
var detector = new FizzBuzzDetector();

var result = detector.getOverlappings(input);

Console.WriteLine(result.Output);
Console.WriteLine(result.Count);
```

## Build

```bash
dotnet build
```

## Run Tests

```bash
dotnet test
```
