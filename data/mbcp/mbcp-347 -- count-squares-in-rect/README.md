# mbcp-347 -- Count squares in a rectangle using a Python function

## Text

Write a C# function to count the number of squares in a rectangle.

## Code

```csharp
public static int CountSquares(int m, int n) 
{ 
    if (n < m) 
    { 
        int temp = m; 
        m = n; 
        n = temp; 
    } 
    return n * (n + 1) * (3 * m - n + 1) / 6; 
}
```

## Test List

```csharp
Debug.Assert(CountSquares(4, 3) == 20);
```

```csharp
Debug.Assert(CountSquares(1, 2) == 2);
```

```csharp
Debug.Assert(CountSquares(2, 2) == 5);
```
