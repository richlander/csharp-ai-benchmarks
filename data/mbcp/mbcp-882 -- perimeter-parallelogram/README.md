# mbcp-882 -- Calculate the perimeter of a parallelogram

## Text

Write a function to caluclate perimeter of a parallelogram.

## Code

```csharp
public int ParallelogramPerimeter(int b, int h)
{
    int perimeter = 2 * (b + h);
    return perimeter;
}
```

## Test List

```csharp
Debug.Assert(ParallelogramPerimeter(10, 20) == 400);
```

```csharp
Debug.Assert(ParallelogramPerimeter(15, 20) == 600);
```

```csharp
Debug.Assert(ParallelogramPerimeter(8, 9) == 144);
```
