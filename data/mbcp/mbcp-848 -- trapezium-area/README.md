# mbcp-848 -- Calculate the area of a trapezium with a function

## Text

Write a function to find the area of a trapezium.

## Code

```csharp
public double AreaTrapezium(double base1, double base2, double height)
{
    double area = 0.5 * (base1 + base2) * height;
    return area;
}
```

## Test List

```csharp
Debug.Assert(AreaTrapezium(6, 9, 4) == 30);
```

```csharp
Debug.Assert(AreaTrapezium(10, 20, 30) == 450);
```

```csharp
Debug.Assert(AreaTrapezium(15, 25, 35) == 700);
```
