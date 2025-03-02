# mbcp660 -- Select points from two distinct ranges in Python

## Text

Write a C# function to choose points from two ranges such that no point lies in both the ranges.

## Code

```csharp
public (int, int) FindPoints(int l1, int r1, int l2, int r2) 
{ 
    int x = (l1 != l2) ? Math.Min(l1, l2) : -1; 
    int y = (r1 != r2) ? Math.Max(r1, r2) : -1; 
    return (x, y); 
}
```

## Test List

```csharp
Debug.Assert(FindPoints(5, 10, 1, 5).Equals((1, 10)));
```

```csharp
Debug.Assert(FindPoints(3, 5, 7, 9).Equals((3, 9)));
```

```csharp
Debug.Assert(FindPoints(1, 5, 2, 8).Equals((1, 8)));
```
