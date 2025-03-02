# mbcp-654 -- Calculate the rectangle's perimeter using a function

## Text

Write a function to find the perimeter of a rectangle.

## Code

```csharp
public int RectanglePerimeter(int l, int b)  
{  
    int perimeter = 2 * (l + b);  
    return perimeter;  
}
```

## Test List

```csharp
Debug.Assert(RectanglePerimeter(10, 20) == 60);
```

```csharp
Debug.Assert(RectanglePerimeter(10, 5) == 30);
```

```csharp
Debug.Assert(RectanglePerimeter(4, 2) == 12);
```
