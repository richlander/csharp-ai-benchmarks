# mbcp80 -- Find the nth tetrahedral number efficiently

## Text

Write a function to find the nth tetrahedral number.

## Code

```csharp
public static double TetrahedralNumber(int n) 
{ 
    return (n * (n + 1) * (n + 2)) / 6.0; 
}
```

## Test List

```csharp
Debug.Assert(TetrahedralNumber(5) == 35.0);
```

```csharp
Debug.Assert(TetrahedralNumber(6) == 56.0);
```

```csharp
Debug.Assert(TetrahedralNumber(7) == 84.0);
```
