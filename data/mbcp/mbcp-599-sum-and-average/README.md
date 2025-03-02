# mbcp599 -- Sum and average of first n natural numbers

## Text

Write a function to find sum and average of first n natural numbers.

## Code

```csharp
public (int Total, double Average) SumAverage(int number)
{
    int total = 0;
    for (int value = 1; value <= number; value++)
    {
        total += value;
    }
    double average = (double)total / number;
    return (total, average);
}
```

## Test List

```csharp
Debug.Assert(SumAverage(10).Equals((55, 5.5)));
```

```csharp
Debug.Assert(SumAverage(15).Item1 == 120 && SumAverage(15).Item2 == 8.0);
```

```csharp
Debug.Assert(SumAverage(20).Equals((210, 10.5)));
```
