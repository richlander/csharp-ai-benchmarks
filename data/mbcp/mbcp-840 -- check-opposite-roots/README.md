# mbcp-840 -- Check if quadratic roots are equal and opposite

## Text

Write a C# function to check whether the roots of a quadratic equation are numerically equal but opposite in sign or not.

## Code

```csharp
public string CheckSolution(int a, int b, int c)  
{  
    if (b == 0)  
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
Debug.Assert(CheckSolution(2, 0, -1) == "Yes");
```

```csharp
Debug.Assert(CheckSolution(1, -5, 6) == "No");
```

```csharp
Debug.Assert(CheckSolution(2, 0, 2) == "Yes");
```
