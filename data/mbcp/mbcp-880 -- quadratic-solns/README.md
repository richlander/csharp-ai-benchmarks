# mbcp-880 -- Calculate solutions for quadratic equations in Python

## Text

Write a C# function to find number of solutions in quadratic equation.

## Code

```csharp
public string CheckSolution(int a, int b, int c) 
{ 
    if ((b * b) - (4 * a * c) > 0) 
    { 
        return "2 solutions"; 
    } 
    else if ((b * b) - (4 * a * c) == 0) 
    { 
        return "1 solution"; 
    } 
    else 
    { 
        return "No solutions"; 
    } 
}
```

## Test List

```csharp
Debug.Assert(CheckSolution(2, 5, 2) == "2 solutions");
```

```csharp
Debug.Assert(CheckSolution(1, 1, 1) == "No solutions");
```

```csharp
Debug.Assert(CheckSolution(1, 2, 1) == "1 solution");
```
