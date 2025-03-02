# mbcp219 -- Extract max and min k elements from a tuple

## Text

Write a function to extract maximum and minimum k elements in the given tuple.

## Code

```csharp
public static Tuple<int[]> ExtractMinMax(Tuple<int>[] testTup, int K)
{
    List<int> res = new List<int>();
    List<int> temp = testTup.ToList().Select(t => t.Item1).ToList();
    temp.Sort();
    for (int idx = 0; idx < temp.Count; idx++)
    {
        if (idx < K || idx >= temp.Count - K)
        {
            res.Add(temp[idx]);
        }
    }
    return Tuple.Create(res.ToArray());
}
```

## Test List

```csharp
Debug.Assert(ExtractMinMax(new Tuple<int, int, int, int, int, int>(5, 20, 3, 7, 6, 8), 2).Equals(new Tuple<int, int, int, int>(3, 5, 8, 20)));
```

```csharp
Debug.Assert(ExtractMinMax(new int[] { 4, 5, 6, 1, 2, 7 }, 3).SequenceEqual(new int[] { 1, 2, 4, 5, 6, 7 }));
```

```csharp
Debug.Assert(ExtractMinMax(new int[] { 2, 3, 4, 8, 9, 11, 7 }, 4).SequenceEqual(new int[] { 2, 3, 4, 7, 8, 9, 11 }));
```
