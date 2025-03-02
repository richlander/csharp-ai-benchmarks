# mbcp432 -- Calculate the median of a trapezium shape

## Text

Write a function to find the median of a trapezium.

## Code

```csharp
public double MedianTrapezium(double base1, double base2, double height)  
{  
    double median = 0.5 * (base1 + base2);  
    return median;  
}
```

## Test List

```csharp
Debug.Assert(MedianTrapezium(15, 25, 35) == 20);
```

```csharp
Debug.Assert(MedianTrapezium(10, 20, 30) == 15);
```

```csharp
Debug.Assert(MedianTrapezium(6, 9, 4) == 7.5);
```
