# mbcp176 -- Calculate the perimeter of a triangle using a function

## Text

Write a function to find the perimeter of a triangle.

## Code

```csharp
public int PerimeterTriangle(int a, int b, int c)
{
    int perimeter = a + b + c;
    return perimeter;
}
```

## Test List

```csharp
Debug.Assert(PerimeterTriangle(10, 20, 30) == 60);
```

```csharp
Debug.Assert(PerimeterTriangle(3, 4, 5) == 12);

public static int PerimeterTriangle(int a, int b, int c)
{
    return a + b + c;
}
```

```csharp
Debug.Assert(PerimeterTriangle(25, 35, 45) == 105);
```
