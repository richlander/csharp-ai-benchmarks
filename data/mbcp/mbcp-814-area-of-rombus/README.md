# mbcp814 -- Calculate the area of a rhombus using a function

## Text

Write a function to find the area of a rombus.

## Code

```csharp
public double RombusArea(double p, double q) 
{
    double area = (p * q) / 2;
    return area;
}
```

## Test List

```csharp
Debug.Assert(RombusArea(10, 20) == 100);

public static double RombusArea(double d1, double d2) {
    return (d1 * d2) / 2;
}
```

```csharp
Debug.Assert(RombusArea(10, 5) == 25);
```

```csharp
Debug.Assert(RombusArea(4, 2) == 4);

public static double RombusArea(double d1, double d2)
{
    return (d1 * d2) / 2;
}
```
