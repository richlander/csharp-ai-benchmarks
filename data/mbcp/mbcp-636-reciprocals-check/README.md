# mbcp636 -- Check if quadratic roots are reciprocals

## Text

Write a C# function to check if roots of a quadratic equation are reciprocal of each other or not.

## Code

```csharp
public string CheckSolution(int a, int b, int c) 
{ 
    if (a == c) 
    { 
        return "Yes"; 
    } 
    else 
    { 
        return "No"; 
    } 
}
```

## Test List

```csharp
Debug.Assert(CheckSolution(2, 0, 2) == "Yes");
```

```csharp
Debug.Assert(CheckSolution(2, -5, 2) == "Yes");
```

```csharp
Debug.Assert(CheckSolution(1, 2, 3) == "No");
```
