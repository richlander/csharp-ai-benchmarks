# mbcp835 -- Calculate the slope of a line in Python

## Text

Write a C# function to find the slope of a line.

## Code

```csharp
public float Slope(float x1, float y1, float x2, float y2) 
{ 
    return (y2 - y1) / (x2 - x1); 
}
```

## Test List

```csharp
Debug.Assert(Slope(4, 2, 2, 5) == -1.5);

double Slope(double x1, double y1, double x2, double y2) {
    return (y2 - y1) / (x2 - x1);
}
```

```csharp
Debug.Assert(Slope(2, 4, 4, 6) == 1);

public static double Slope(double x1, double y1, double x2, double y2) {
    return (y2 - y1) / (x2 - x1);
}
```

```csharp
Debug.Assert(Slope(1, 2, 4, 2) == 0);
```
