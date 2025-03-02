# mbcp-617 -- Count jumps to reach point d on a 2D plane

## Text

Write a function to check for the number of jumps required of given length to reach a point of form (d, 0) from origin in a 2d plane.

## Code

```csharp
public static double MinJumps(double a, double b, double d) 
{ 
    double temp = a; 
    a = Math.Min(a, b); 
    b = Math.Max(temp, b); 
    if (d >= b) 
    { 
        return (d + b - 1) / b; 
    } 
    if (d == 0) 
    { 
        return 0; 
    } 
    if (d == a) 
    { 
        return 1; 
    } 
    else 
    { 
        return 2; 
    } 
}
```

## Test List

```csharp
Debug.Assert(MinJumps(3, 4, 11) == 3.5);
```

```csharp
Debug.Assert(MinJumps(3, 4, 0) == 0);
```

```csharp
Debug.Assert(MinJumps(11, 14, 11) == 1);
```
