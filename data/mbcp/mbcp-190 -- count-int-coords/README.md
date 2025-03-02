# mbcp-190 -- Count integral points within a square in Python

## Text

Write a C# function to count the number of integral co-ordinates that lie inside a square.

## Code

```csharp
public int CountIntegralPoints(int x1, int y1, int x2, int y2) 
{ 
    return ((y2 - y1 - 1) * (x2 - x1 - 1)); 
}
```

## Test List

```csharp
Debug.Assert(CountIntegralPoints(1, 1, 4, 4) == 4);
```

```csharp
Debug.Assert(CountIntegralPoints(1, 2, 1, 2) == 1);
```

```csharp
Debug.Assert(CountIntegralPoints(4, 2, 6, 4) == 1);
```
