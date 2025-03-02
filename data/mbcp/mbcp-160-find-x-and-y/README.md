# mbcp160 -- Find integers x and y for ax + by = n

## Text

Write a function to find x and y that satisfies ax + by = n.

## Code

```csharp
public (string, int, string, int) Solution(int a, int b, int n) 
{
    int i = 0;
    while (i * a <= n) 
    {
        if ((n - (i * a)) % b == 0) 
        {
            return ("x = ", i, ", y = ", (n - (i * a)) / b);
        }
        i++;
    }
    return ("No solution");
}
```

## Test List

```csharp
Debug.Assert(Solution(2, 3, 7).Equals(Tuple.Create("x = ", 2, ", y = ", 1)));
```

```csharp
Debug.Assert(Solution(4, 2, 7) == "No solution");
```

```csharp
Debug.Assert(Solution(1, 13, 17).Equals(Tuple.Create("x = ", 4, ", y = ", 1)));
```
