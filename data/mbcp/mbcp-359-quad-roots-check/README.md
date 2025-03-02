# mbcp359 -- Check if one quadratic root is double the other

## Text

Write a C# function to check whether one root of the quadratic equation is twice of the other or not.

## Code

```csharp
public string CheckSolution(int a, int b, int c) 
{ 
    if (2 * b * b == 9 * a * c) 
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
Debug.Assert(CheckSolution(1, 3, 2) == "Yes");
```

```csharp
Debug.Assert(CheckSolution(1, 2, 3) == "No");
```

```csharp
Debug.Assert(CheckSolution(1, -5, 6) == "No");
```
