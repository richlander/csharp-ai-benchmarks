# mbcp-615 -- Calculate average of numbers in tuple of tuples

## Text

Write a function to find average value of the numbers in a given tuple of tuples.

## Code

```csharp
public List<double> AverageTuple(List<List<double>> nums)
{
    var result = nums.Select(x => x.Select((v, i) => new { v, i })
                                    .GroupBy(y => y.i, y => y.v)
                                    .Average(g => g.Average()))
                     .ToList();
    return result;
}
```

## Test List

```csharp
Debug.Assert(AverageTuple(new (int, int, int, int)[] { (10, 10, 10, 12), (30, 45, 56, 45), (81, 80, 39, 32), (1, 2, 3, 4) }).SequenceEqual(new double[] { 30.5, 34.25, 27.0, 23.25 }));
```

```csharp
Debug.Assert(AverageTuple(new (int, int, int)[]{ (1, 1, -5), (30, -15, 56), (81, -60, -39), (-10, 2, 3) }).SequenceEqual(new double[]{ 25.5, -18.0, 3.75 }));
```

```csharp
Debug.Assert(AverageTuple(new (int, int, int, int)[] { (100, 100, 100, 120), (300, 450, 560, 450), (810, 800, 390, 320), (10, 20, 30, 40) }).SequenceEqual(new double[] { 305.0, 342.5, 270.0, 232.5 }));
```
