# mbcp17 -- Calculate the perimeter of a square given its side

## Text

Write a function to find the perimeter of a square.

## Code

```csharp
public int SquarePerimeter(int a)
{
    int perimeter = 4 * a;
    return perimeter;
}
```

## Test List

```csharp
Debug.Assert(SquarePerimeter(10) == 40);
```

```csharp
Debug.Assert(SquarePerimeter(5) == 20);
```

```csharp
Debug.Assert(SquarePerimeter(4) == 16);
```
