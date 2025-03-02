# mbcp52 -- Calculate the area of a parallelogram function

## Text

Write a function to caluclate area of a parallelogram.

## Code

```csharp
public double ParallelogramArea(double b, double h)  
{  
    double area = b * h;  
    return area;  
}
```

## Test List

```csharp
Debug.Assert(ParallelogramArea(10, 20) == 200);
```

```csharp
Debug.Assert(ParallelogramArea(15, 20) == 300);
```

```csharp
Debug.Assert(ParallelogramArea(8, 9) == 72);

public static double ParallelogramArea(double baseLength, double height)
{
    return baseLength * height;
}
```
