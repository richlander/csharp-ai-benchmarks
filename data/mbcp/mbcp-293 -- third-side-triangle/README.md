# mbcp-293 -- Calculate the third side of a right triangle

## Text

Write a function to find the third side of a right angled triangle.

## Code

```csharp
public static double OthersideRightangle(double w, double h) {
    double s = Math.Sqrt((w * w) + (h * h));
    return s;
}
```

## Test List

```csharp
Debug.Assert(OthersideRightangle(7, 8) == 10.63014581273465);
```

```csharp
Debug.Assert(OthersideRightangle(3, 4) == 5);
```

```csharp
Debug.Assert(OthersideRightangle(7, 15) == 16.55294535724685);

public static double OthersideRightangle(double a, double b)
{
    return Math.Sqrt(a * a + b * b);
}
```
