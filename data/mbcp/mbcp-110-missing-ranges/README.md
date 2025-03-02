# mbcp110 -- Extract missing ranges from a specified interval

## Text

Write a function to extract the ranges that are missing from the given list with the given start range and end range values.

## Code

```csharp
public List<(int, int)> ExtractMissing(List<(int, int)> testList, int strtVal, int stopVal) 
{
    var res = new List<(int, int)>();
    foreach (var sub in testList) 
    {
        if (sub.Item1 > strtVal) 
        {
            res.Add((strtVal, sub.Item1));
            strtVal = sub.Item2;
        }
        if (strtVal < stopVal) 
        {
            res.Add((strtVal, stopVal));
        }
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(ExtractMissing(new List<(int, int)> { (6, 9), (15, 34), (48, 70) }, 2, 100).SequenceEqual(new List<(int, int)> { (2, 6), (9, 100), (9, 15), (34, 100), (34, 48), (70, 100) }));
```

```csharp
Debug.Assert(ExtractMissing(new List<(int, int)> { (7, 2), (15, 19), (38, 50) }, 5, 60).SequenceEqual(new List<(int, int)> { (5, 7), (2, 60), (2, 15), (19, 60), (19, 38), (50, 60) }));
```

```csharp
Debug.Assert(ExtractMissing(new (int, int)[] { (7, 2), (15, 19), (38, 50) }, 1, 52).SequenceEqual(new (int, int)[] { (1, 7), (2, 52), (2, 15), (19, 52), (19, 38), (50, 52) }));
```
