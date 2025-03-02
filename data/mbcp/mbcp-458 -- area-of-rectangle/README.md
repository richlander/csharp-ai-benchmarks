# mbcp-458 -- Calculate area of a rectangle using a function

## Text

Write a function to find the area of a rectangle.

## Code

```csharp
public int RectangleArea(int l, int b)
{
    int area = l * b;
    return area;
}
```

## Test List

```csharp
Debug.Assert(RectangleArea(10, 20) == 200);
```

```csharp
Debug.Assert(RectangleArea(10, 5) == 50);
```

```csharp
Debug.Assert(RectangleArea(4, 2) == 8);
```
