# mbcp960 -- Function to solve the tiling problem efficiently

## Text

Write a function to solve tiling problem.

## Code

```csharp
public int GetNoOfWays(int n) 
{
    if (n == 0) 
    {
        return 0;
    }
    if (n == 1) 
    {
        return 1;
    }
    return GetNoOfWays(n - 1) + GetNoOfWays(n - 2);
}
```

## Test List

```csharp
Debug.Assert(GetNoOfWays(4) == 3);
```

```csharp
Debug.Assert(GetNoOfWays(3) == 2);
```

```csharp
Debug.Assert(GetNoOfWays(5) == 5);
```
