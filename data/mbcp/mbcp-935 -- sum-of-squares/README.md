# mbcp-935 -- Calculate the sum of squares up to n

## Text

Write a function to calculate the sum of series 1²+2²+3²+….+n².

## Code

```csharp
public static double SeriesSum(int number)
{
    double total = 0;
    total = (number * (number + 1) * (2 * number + 1)) / 6.0;
    return total;
}
```

## Test List

```csharp
Debug.Assert(SeriesSum(6) == 91);
```

```csharp
Debug.Assert(SeriesSum(7) == 140);
```

```csharp
Debug.Assert(SeriesSum(12) == 650);
```
